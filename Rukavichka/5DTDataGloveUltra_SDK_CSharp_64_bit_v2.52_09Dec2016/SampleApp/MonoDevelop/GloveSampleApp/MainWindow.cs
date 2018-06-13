using System;
using System.Timers;
using Gtk;
using FDTGloveUltraCSharpWrapper;

public partial class MainWindow : Gtk.Window
{
	CfdGlove fdGlove;
	private static System.Timers.Timer tmrUpdate;
	
	public MainWindow () : base(Gtk.WindowType.Toplevel)
	{
		Build ();
		
		// creat the glove
		fdGlove = new CfdGlove();
		
		// setup the timer
		tmrUpdate = new System.Timers.Timer();
  	    tmrUpdate.Elapsed += new ElapsedEventHandler(OurTimerCallback);
        tmrUpdate.Disposed += new EventHandler(OurTimerDisposed);
        tmrUpdate.Interval = 250;
        tmrUpdate.Enabled = true;
	}
	
	delegate void UpdateListDelegate(); // used by Update function to create delegate to update sensor list
	
	public void OurTimerCallback(object source, ElapsedEventArgs e)
    {
		Update(this,new EventArgs());
	}

    public void OurTimerDisposed(object source, EventArgs e)
    {
    }
	
	private void Update(object sender, EventArgs e)
	{
		Gtk.Application.Invoke (delegate {UpdateDataOnForm();});
	}
	
	private void UpdateDataOnForm()
	{
        if (fdGlove == null)
        return;
        
        lstSensors.Buffer.Text = "";
    	
        ushort[] arr = new ushort[20];
        float[] farr = new float[20];

        // Get all the scaled values
        fdGlove.GetSensorScaledAll(ref farr);
		fdGlove.GetSensorRawAll(ref arr);
        
        //for (int i = 0; i < fdGlove.GetNumSensors(); ++i)
        if (fdGlove.IsOpen())
        {
            for (int i = 0; i < 18; ++i)
            {
				lstSensors.Buffer.Text += "Sensor " + i + " - Scaled: " + String.Format("{0:0.00}", farr[i]) + " ( Raw: " + arr[i] + ")\n";                
            }

        }
        txtGesture.Text = fdGlove.GetGesture().ToString();
        txtPacketRate.Text = fdGlove.GetPacketRate().ToString();	
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected virtual void OnBtnConnectClicked (object sender, System.EventArgs e)
	{
		chkUseCallback.Active = false;
        fdGlove.Open(txtGlovePort.Text);
        //tmrUpdate.Enabled = true;

        switch(fdGlove.GetGloveType())
        {
            case (int)EGloveTypes.FD_GLOVE14UW: txtType.Text = "Data Glove 14 Ultra Wireless"; break;
            case (int)EGloveTypes.FD_GLOVE14U_USB: txtType.Text = "Data Glove 14 Ultra USB"; break;
            case (int)EGloveTypes.FD_GLOVE14U: txtType.Text = "Data Glove 14 Ultra"; break;
            case (int)EGloveTypes.FD_GLOVE16: txtType.Text = "Data Glove 16-sensor"; break;
            case (int)EGloveTypes.FD_GLOVE16W: txtType.Text = "Data Glove 16-sensor Wireless"; break;
            case (int)EGloveTypes.FD_GLOVE5U: txtType.Text = "Data Glove 5 Ultra"; break;
            case (int)EGloveTypes.FD_GLOVE5U_USB: txtType.Text = "Data Glove 5 Ultra USB"; break;
            case (int)EGloveTypes.FD_GLOVE5UW: txtType.Text = "Data Glove 5 Ultra Wireless"; break;
            case (int)EGloveTypes.FD_GLOVE7: txtType.Text = "Data Glove 7-sensor"; break;
            case (int)EGloveTypes.FD_GLOVE7W: txtType.Text = "Data Glove 7-sensor Wireless"; break;
            case (int)EGloveTypes.FD_GLOVENONE: txtType.Text = "No Glove"; break;
            default: txtType.Text = "Unknown"; break;
        }
            
        switch(fdGlove.GetGloveHand())
        {
            case (int)EGloveHand.FD_HAND_RIGHT: txtLR.Text = "Right"; break;
            case (int)EGloveHand.FD_HAND_LEFT: txtLR.Text = "Left"; break;
        }

        txtFirmWareVersion.Text = fdGlove.fdGetFWVersionMajor() + "." + fdGlove.fdGetFWVersionMinor();
	}
	
	protected virtual void OnBtnQuitClicked (object sender, System.EventArgs e)
	{
		if (fdGlove != null)
        	fdGlove.Close();
        Application.Quit();
	}
	
	protected virtual void OnChkUseCallbackToggled (object sender, System.EventArgs e)
	{
		    if (chkUseCallback.Active)
            {
                fdGlove.SetCallBack(new EventHandler(Update));
                tmrUpdate.Enabled = false;
            }
            else
            {
                fdGlove.RemoveCallBack(new EventHandler(Update));
                tmrUpdate.Enabled = true;
            }
	}
	
	
	
	
}

