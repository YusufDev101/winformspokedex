using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class List : UserControl
    {
        #region Constants
        
        private const string CONST_NetworkNotConnected = "Network not connected";

        #endregion

        #region Properties

        // var for reconnecting.
        private bool reconnecting;
        //private readonly DataAccess _dataAccess;

        // Must overide, this adds a new control.
        public delegate void GenerateControl(string id, Dictionary<string, object> record, List list);
             
        public string SQLIDProperty { get; set; }
        public Form FormInvoker { get; set; }
        public GenerateControl DelegatedGenerateControl { get; set; }

        // Private vars.
        private Thread thread;
        private bool threading;

        // Public vars
        public Form parent;
        public AutoResetEvent autoEvent;

        #endregion

        #region Constructor(s)

        public List()
        {
            // Initialise the data access component.
           // _dataAccess = DataAccess.GetInstance;

            InitializeComponent();

            this.reconnecting = false;
            this.autoEvent = new AutoResetEvent(false);
            this.thread = new Thread(this.Run) { Name = this.GetType().Name };
        }

        #endregion

        #region Event Handler(s)

        // Event Handling for item mouse click.
        public event ListItemClickEventHandler ListItemClick;

        public delegate void ListItemClickEventHandler(object sender, ListItemEventArgs e);

        public virtual void OnListItemClick(object sender, ListItemEventArgs e)
        {
            // Make sure the event is not null.
            if (ListItemClick != null)
            {
                // Invoke the event.
                ListItemClick(this, e);
            }
        }



        // Event Handling for item mouse double click.
        public event ListItemDoubleClickEventHandler ListItemDoubleClick;

        public delegate void ListItemDoubleClickEventHandler(object sender, ListItemEventArgs e);

        public virtual void OnListItemDoubleClick(object sender, ListItemEventArgs e)
        {
            // Make sure the event is not null.
            if (ListItemDoubleClick != null)
            {
                // Invoke the event.
                ListItemDoubleClick(this, e);
            }
        }



        // Event Handling for item mouse enter.
        public event ListItemMouseEnterEventHandler ListItemMouseEnter;

        public delegate void ListItemMouseEnterEventHandler(object sender, ListItemEventArgs e);

        public virtual void OnListItemMouseEnter(object sender, ListItemEventArgs e)
        {
            // Make sure the event is not null.
            if (ListItemMouseEnter != null)
            {
                // Invoke the event.
                ListItemMouseEnter(this, e);
            }
        }



        // Event Handling for item mouse leave.
        public event ListItemMouseLeaveEventHandler ListItemMouseLeave;

        public delegate void ListItemMouseLeaveEventHandler(object sender, ListItemEventArgs e);

        public virtual void OnListItemMouseLeave(object sender, ListItemEventArgs e)
        {
            // Make sure the event is not null.
            if (ListItemMouseLeave != null)
            {
                // Invoke the event.
                ListItemMouseLeave(this, e);
            }
        }



        // Event Handling for item mouse click.
        public event ListItemMouseClickEventHandler ListItemMouseClick;

        public delegate void ListItemMouseClickEventHandler(object sender, ListItemMouseClickEventArgs e);

        public virtual void OnListItemMouseClick(object sender, ListItemMouseClickEventArgs e)
        {
            // Make sure the event is not null.
            if (ListItemMouseClick != null)
            {
                // Invoke the event.
                ListItemMouseClick(this, e);
            }
        }



        // Event Handler for item SQL Errors.
        public delegate void ListLoadingError(object sender, ListSQLEventArgs e);

        public event ListLoadingError SQLListLoadingError;

        public virtual void OnListLoadingError(object sender, ListSQLEventArgs e)
        {
            if (SQLListLoadingError != null)
            {
                SQLListLoadingError(this, e);
            }
        }

        #endregion

        // Stop the list.
        public void Stop()
        {
            this.threading = false;
            this.thread.Abort();
        }

        // Start the list.
        public void Start()
        {
            try
            {
                // Try and catch prevents app from crashing.
                this.thread.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw ex;
            }
        }

        // Method to be called when SQL errors.
        public void SQLError()
        {
            try
            {
                this.FormInvoker.BeginInvoke(new MethodInvoker(() =>
                {
                    this.ResumeLayout();
                    if (!this.reconnecting)
                    {
                        this.Controls.Clear();
                        this.reconnecting = true;
                    }

                    this.Controls.Add(new Label
                    {
                        Text = CONST_NetworkNotConnected,
                        TextAlign = ContentAlignment.MiddleCenter,
                        BackColor = Color.Transparent,
                        Dock = DockStyle.Fill,
                        Font = new Font("Microsoft Sans Serif", 9),
                        ForeColor = System.Drawing.Color.Red
                    });
                    this.autoEvent.Set();
                }));

                this.autoEvent.WaitOne();
                //Thread.Sleep(this.Interval);
            }
            catch (Exception)
            {
                //throw;
            }
        }

        // Run the list.
        private void Run()
        {
            try
            {
                this.threading = true;
                while (this.threading)
                {
                    this.FormInvoker.BeginInvoke(new MethodInvoker(() =>
                    {
                        this.SuspendLayout();
                        this.autoEvent.Set();
                    }));

                    this.autoEvent.WaitOne();

                    this.Process();

                    this.FormInvoker.BeginInvoke(new MethodInvoker(() =>
                    {
                        this.ResumeLayout();
                        this.autoEvent.Set();
                    }));
                    this.autoEvent.WaitOne();

                    //Thread.Sleep(this.Interval);
                }
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (SystemException ex)
            {
                SQLError();
                Console.WriteLine("SystemException: " + ex.Message);

            }
            catch (Exception ex)
            {
                SQLError();
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        // Process data from SQL.
        private void Process()
        {
            Dictionary<string, object>[] result = null;

            try
            {
                //result = _dataAccess.ExecuteServiceToArray(this.SQLProcedure, this.SQLParams, this.SQLUsername);
            }
            catch (SqlException e)
            {
                SQLError();
                Console.WriteLine("SqlException: " + e.Message);
                //this.OnListLoadingError(this, new ListSQLEventArgs { Exception = e });
                //throw e;
            }
            catch (InvalidOperationException e)
            {
                SQLError();
                Console.WriteLine("InvalidOperationException: " + e.Message);
            }
            catch (SystemException e)
            {
                SQLError();
                Console.WriteLine("SystemException: " + e.Message);
            }
            catch (Exception e)
            {
                SQLError();
                Console.WriteLine("Exception: " + e.Message);
            }

            if (result == null)
            {
                this.SQLError();
                return;
            }

            if (this.reconnecting)
            {
                this.reconnecting = false;
                this.FormInvoker.BeginInvoke(new MethodInvoker(() =>
                {
                    this.Controls.Clear();
                    this.autoEvent.Set();
                }));
                this.autoEvent.WaitOne();
            }

            List<string> safe = new List<string>();

            // EDIT, ELSE ADD.
            if (result != null)
            {
                foreach (var record in result)
                {
                    var id = Convert.ToString(record[this.SQLIDProperty]);
                    safe.Add(id);

                    if (this.Controls.ContainsKey(id))
                    {
                        var item = (ListItem)this.Controls[id];
                        item.Record = record;

                        this.FormInvoker.BeginInvoke(new MethodInvoker(() =>
                        {
                            item.Process();
                            this.autoEvent.Set();
                        }));

                        this.autoEvent.WaitOne();
                    }
                    else
                    {
                        var copy = record;
                        this.FormInvoker.BeginInvoke(new MethodInvoker(() =>
                        {
                            this.DelegatedGenerateControl(id, copy, this);
                            this.autoEvent.Set();
                        }));
                        this.autoEvent.WaitOne();
                    }
                }
            }

            int[] i; // Resharper wanted this to be done like this.
            for (i = new[] { 0 }; i[0] < this.Controls.Count; i[0]++)
            {
                if (safe.Contains(this.Controls[i[0]].Name)) continue;
                this.FormInvoker.BeginInvoke(new MethodInvoker(() =>
                {
                    this.Controls[i[0]].Dispose();
                    this.autoEvent.Set();
                    i[0]--;
                }));
                this.autoEvent.WaitOne();
            }
        }
    }
}