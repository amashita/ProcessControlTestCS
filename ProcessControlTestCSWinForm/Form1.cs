using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessControlTestCSWinForm
{
    public partial class Form1 : Form
    {
        private ProcessController _processController = new ProcessController();
        private BindingList<SystemProcessInformation> _processInfos = null;

        public Form1()
        {
            InitializeComponent();

            var prosessInfos = _processController.GetProcessInfo();
            _processInfos = new BindingList<SystemProcessInformation>(prosessInfos);
            procListGridView.DataSource = prosessInfos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var prosessInfos = _processController.GetProcessInfo();

            bool restore = _processInfos.RaiseListChangedEvents;
            try
            {
                _processInfos.RaiseListChangedEvents = false;

                _processInfos.Clear();
                foreach (var v in prosessInfos)
                    _processInfos.Add(v);
            }
            finally
            {
                _processInfos.RaiseListChangedEvents = restore;
                if (_processInfos.RaiseListChangedEvents)
                    _processInfos.ResetBindings();
            }
        }
    }
}
