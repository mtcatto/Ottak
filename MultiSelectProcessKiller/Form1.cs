using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;


namespace ProcessKiller
{
    public partial class frmMainnnnnn : Form
    {
        public frmMainnnnnn()
        {
            InitializeComponent();
            InitStuff();
            InitGrid();
        }


        //string thingsToKill = ",AdobeUpdater,cisvc,GoogleUpdate,VCDDaemon,jucheck,jusched,stsystra,";
        string thingsToKill = "fgghfghfghfghfgh";
        string whatToEditConfigWith = "fgghfghfghfghfgh";
        int debug = 0;
        bool safeMode = true;
        const string ckSafeModeText = "Prompt Yes/No for each delete? ";
        const int colKill  = 0;
        const int colName  = 1;
        const int colPID =2;
        const int colRespond = 3;
        const int colThreads = 4;
        const int colModules = 5;
        const int colStartTime = 6;
        const int colPagedMem = 7;
        const int colNonPagedMem = 8;
        System.IO.FileSystemWatcher watchConfig;

       public void InitStuff()
        {
            //read App.Config
            System.Configuration.AppSettingsReader rdr = new System.Configuration.AppSettingsReader();
            thingsToKill = (string)rdr.GetValue("thingsToKill", thingsToKill.GetType());
            whatToEditConfigWith = (string)rdr.GetValue("whatToEditConfigWith", whatToEditConfigWith.GetType());
            debug = (int)rdr.GetValue("debug", debug.GetType());
            safeMode = (bool)rdr.GetValue("safeMode", safeMode.GetType());

            //SET up file watcher to restart EXE upon config change
            //string path = Process.GetCurrentProcess().MainModule.FileName;
            //path = path.Replace("vshost.exe", "exe.config");
            //watchConfig = new System.IO.FileSystemWatcher(path);
            watchConfig = new System.IO.FileSystemWatcher(".", "ProcessKiller.exe.config");
            watchConfig.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            watchConfig.Changed += new System.IO.FileSystemEventHandler(configChanged);
            watchConfig.EnableRaisingEvents = true;
        }

       private static void configChanged(object source, System.IO.FileSystemEventArgs e)
       {
           //  Show that a file has been created, changed, or deleted.
           System.IO.WatcherChangeTypes wct = e.ChangeType;
           
           //config changed, start ne process then kill me
           Process killer = new Process();
           killer.StartInfo.FileName = "ProcessKiller.exe";
           killer.Start();

           Process.GetCurrentProcess().Kill();   
       }
   

        public void KillProcessesFromConfig()
        {
            string pName = "";
            string pNames = "";
            string killedpNames = "";

            if (debug == 1)
            {
                MessageBox.Show(this, "The kill list ..... \n\n " + thingsToKill);
            }
            //3.5 framework
            //foreach (Process opro in Process.GetProcesses().OrderBy(p => p.ProcessName))
                
            //2.0 framework
            foreach (Process opro in Process.GetProcesses(   ))
            {
                pName = opro.ProcessName ;
                pNames += opro.ProcessName + "\t\t" + opro.Id + "\t\t" + opro.VirtualMemorySize + "\t\t" + opro.PrivateMemorySize + "\n";
                //pNames += opro.ProcessName + "\n";

                if (thingsToKill.Contains("," + pName + ",") == true)
                {
                    killedpNames += opro.ProcessName + "\n";
                    if (debug == 1)
                    {
                        MessageBox.Show(this, "Killing ......  " + pName);
                    }
                    opro.Kill(); 
                }

            }

            if (debug == 1)
            {
                MessageBox.Show(this, "All the processes found ..... \n\n " + pNames);
            }

            MessageBox.Show(this, "The things killed ..... \n\n " + killedpNames);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.KillProcesses();
        }



        public void InitGrid()
        {
            string pName = "";
            string pNames = "";
            int debug = 0;
            object[] rparams = new object[9];

            if (safeMode == true)
            {
                ckSafeMode.Checked = true;
                ckSafeMode.Enabled = false;
                ckSafeMode.Text = ckSafeModeText + " (Change App.Config value to false to enable choice.) ";
            }

            dgProcs.Rows.Clear();

            if (debug == 1)
            {
                MessageBox.Show(this, "The kill list ..... \n\n " + thingsToKill);
            }
            //3.5 framework
            //foreach (Process opro in Process.GetProcesses().OrderBy(p => p.ProcessName))

            //2.0 framework
            //foreach (Process opro in Process.GetProcesses()  )
            foreach (Process opro in Process.GetProcesses().OrderBy(p => p.ProcessName))
            {
                pName = opro.ProcessName;
                pNames += opro.ProcessName + "\t\t" + opro.Id + "\t\t" + opro.VirtualMemorySize + "\t\t" + opro.PrivateMemorySize + "\n";
                //pNames += opro.ProcessName + "\n";

                rparams[colName] = opro.ProcessName;
                rparams[colPID] = opro.Id;
                rparams[colKill] = false;
                rparams[colPagedMem] = opro.PagedMemorySize64.ToString();
                rparams[colNonPagedMem] = opro.NonpagedSystemMemorySize64.ToString();
                rparams[colRespond] = opro.Responding;
                rparams[colThreads] = opro.Threads.Count;
                rparams[colModules] = opro.HandleCount;
              

                try { rparams[colStartTime] = opro.TotalProcessorTime.ToString(); }
                catch { rparams[colStartTime] = "Ex"; }

                if (thingsToKill.Contains("," + pName + ",") == true)
                {
                    rparams[colKill] = true;
                }

                dgProcs.Rows.Add(rparams);
            }

            if (debug == 1)
            {
                MessageBox.Show(this, "All the processes found ..... \n\n " + pNames);
            }

            dgProcs.Sort(dgProcs.Columns[colKill], ListSortDirection.Descending);
            //dgProcs.Sort(dgProcs.Columns[0], ListSortDirection.Ascending);
            
        }

        public void KillProcesses()
        {
            try
            {
                DialogResult response;

                for (int i = 0; i < dgProcs.Rows.Count - 1; i++)
                {
                    if ((bool)dgProcs.Rows[i].Cells[colKill].Value == true)
                    {
                        if ((safeMode == true) || (ckSafeMode.Checked == true))
                        {
                            response = MessageBox.Show(this, "Killing ......  " + (string)dgProcs.Rows[i].Cells[colName].Value, "Killing", MessageBoxButtons.YesNo);
                            if (response == DialogResult.Yes)
                            {
                                System.Diagnostics.Process.GetProcessById((int)dgProcs.Rows[i].Cells[colPID].Value).Kill();
                            }
                        }
                        else
                        {
                            if (debug == 1) { MessageBox.Show(this, "Killing ......  " + (string)dgProcs.Rows[i].Cells[colName].Value); }
                            System.Diagnostics.Process.GetProcessById((int)dgProcs.Rows[i].Cells[colPID].Value).Kill();
                        }
                    }
                }
                System.Threading.Thread.Sleep(1000);
                InitGrid();
            }
            catch (Exception ex)
            {
                InitGrid();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitStuff();
            InitGrid();
        }

        private void btnEditConfig_Click(object sender, EventArgs e)
        {
            //quick and dirty, full path to wherever the exe is running....replacing ending with config ending
            string configFile = Process.GetCurrentProcess().MainModule.FileName;
            string configFile2 = configFile.Replace(".exe", ".exe.config");
            if (debug == 1)
            {
                MessageBox.Show(this, "Config  .....  " + configFile + "\n\nConfig after replace .....  " + configFile2);
            }

            //defualt is notepad.exe.....can be textpad, wordpad, xmlspy, whatever..
            Process notePad = new Process();
            notePad.StartInfo.FileName =  whatToEditConfigWith;
            //notePad.StartInfo.Arguments = Process.GetCurrentProcess().ProcessName + ".exe.config";
            notePad.StartInfo.Arguments = '"' + configFile2 + '"';
            notePad.Start();
        }


        private int GetTotalCPU()
        {
            int _retVal = 0;
            foreach (Process opro in Process.GetProcesses().OrderBy(p => p.ProcessName))
            {
                
            }
            return _retVal;
        }

  

        private void btnExit_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();   

        }

    }
}
