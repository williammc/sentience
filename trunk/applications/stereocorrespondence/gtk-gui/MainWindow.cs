// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.Action File;
    
    private Gtk.Action Exit;
    
    private Gtk.Action View;
    
    private Gtk.Action Quality;
    
    private Gtk.Action Low;
    
    private Gtk.Action Medium;
    
    private Gtk.Action High;
    
    private Gtk.Action DepthMap;
    
    private Gtk.Action SimpleStereo;
    
    private Gtk.VBox vbox1;
    
    private Gtk.MenuBar menubar1;
    
    private Gtk.HBox hbox2;
    
    private Gtk.VBox vbox2;
    
    private Gtk.HBox hbox3;
    
    private Gtk.Label label1;
    
    private Gtk.TextView txtImagesDirectory;
    
    private Gtk.Button cmdImagesDirectory;
    
    private Gtk.HBox hbox4;
    
    private Gtk.Label label2;
    
    private Gtk.TextView txtCalibrationFilename;
    
    private Gtk.Button cmdCalibrationFilename;
    
    private Gtk.HBox hbox5;
    
    private Gtk.Label label3;
    
    private Gtk.TextView txtStereoCorrespondenceTime;
    
    private Gtk.VBox vbox3;
    
    private Gtk.Button cmdPrevious;
    
    private Gtk.Button cmdNext;
    
    private Gtk.HBox hbox1;
    
    private Gtk.Image picLeftImage;
    
    private Gtk.Image picRightImage;
    
    private Gtk.Image picDepthMap;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize();
        // Widget MainWindow
        Gtk.UIManager w1 = new Gtk.UIManager();
        Gtk.ActionGroup w2 = new Gtk.ActionGroup("Default");
        this.File = new Gtk.Action("File", Mono.Unix.Catalog.GetString("File"), null, null);
        this.File.ShortLabel = Mono.Unix.Catalog.GetString("File");
        w2.Add(this.File, null);
        this.Exit = new Gtk.Action("Exit", Mono.Unix.Catalog.GetString("Exit"), null, null);
        this.Exit.ShortLabel = Mono.Unix.Catalog.GetString("Exit");
        w2.Add(this.Exit, null);
        this.View = new Gtk.Action("View", Mono.Unix.Catalog.GetString("View"), null, null);
        this.View.ShortLabel = Mono.Unix.Catalog.GetString("View");
        w2.Add(this.View, null);
        this.Quality = new Gtk.Action("Quality", Mono.Unix.Catalog.GetString("Quality"), null, null);
        this.Quality.ShortLabel = Mono.Unix.Catalog.GetString("Quality");
        w2.Add(this.Quality, null);
        this.Low = new Gtk.Action("Low", Mono.Unix.Catalog.GetString("Low"), null, null);
        this.Low.ShortLabel = Mono.Unix.Catalog.GetString("Low");
        w2.Add(this.Low, null);
        this.Medium = new Gtk.Action("Medium", Mono.Unix.Catalog.GetString("Medium"), null, null);
        this.Medium.ShortLabel = Mono.Unix.Catalog.GetString("Medium");
        w2.Add(this.Medium, null);
        this.High = new Gtk.Action("High", Mono.Unix.Catalog.GetString("High"), null, null);
        this.High.ShortLabel = Mono.Unix.Catalog.GetString("High");
        w2.Add(this.High, null);
        this.DepthMap = new Gtk.Action("DepthMap", Mono.Unix.Catalog.GetString("Depth Map"), null, null);
        this.DepthMap.ShortLabel = Mono.Unix.Catalog.GetString("Depth Map");
        w2.Add(this.DepthMap, null);
        this.SimpleStereo = new Gtk.Action("SimpleStereo", Mono.Unix.Catalog.GetString("Simple Stereo"), null, null);
        this.SimpleStereo.ShortLabel = Mono.Unix.Catalog.GetString("Simple Stereo");
        w2.Add(this.SimpleStereo, null);
        w1.InsertActionGroup(w2, 0);
        this.AddAccelGroup(w1.AccelGroup);
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("Stereo Correspondence");
        this.WindowPosition = ((Gtk.WindowPosition)(4));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.vbox1 = new Gtk.VBox();
        this.vbox1.Name = "vbox1";
        this.vbox1.Spacing = 6;
        // Container child vbox1.Gtk.Box+BoxChild
        w1.AddUiFromString("<ui><menubar name='menubar1'><menu action='File'><menuitem action='Exit'/></menu><menu action='View'><menuitem action='DepthMap'/><menuitem action='SimpleStereo'/></menu><menu action='Quality'><menuitem action='Low'/><menuitem action='Medium'/><menuitem action='High'/></menu></menubar></ui>");
        this.menubar1 = ((Gtk.MenuBar)(w1.GetWidget("/menubar1")));
        this.menubar1.Name = "menubar1";
        this.vbox1.Add(this.menubar1);
        Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
        w3.Position = 0;
        w3.Expand = false;
        w3.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hbox2 = new Gtk.HBox();
        this.hbox2.Name = "hbox2";
        this.hbox2.Spacing = 6;
        // Container child hbox2.Gtk.Box+BoxChild
        this.vbox2 = new Gtk.VBox();
        this.vbox2.Name = "vbox2";
        this.vbox2.Spacing = 6;
        // Container child vbox2.Gtk.Box+BoxChild
        this.hbox3 = new Gtk.HBox();
        this.hbox3.Name = "hbox3";
        this.hbox3.Spacing = 6;
        // Container child hbox3.Gtk.Box+BoxChild
        this.label1 = new Gtk.Label();
        this.label1.Name = "label1";
        this.label1.LabelProp = Mono.Unix.Catalog.GetString("Stereo Images Directory");
        this.hbox3.Add(this.label1);
        Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox3[this.label1]));
        w4.Position = 0;
        w4.Expand = false;
        w4.Fill = false;
        // Container child hbox3.Gtk.Box+BoxChild
        this.txtImagesDirectory = new Gtk.TextView();
        this.txtImagesDirectory.CanFocus = true;
        this.txtImagesDirectory.Name = "txtImagesDirectory";
        this.hbox3.Add(this.txtImagesDirectory);
        Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox3[this.txtImagesDirectory]));
        w5.Position = 1;
        // Container child hbox3.Gtk.Box+BoxChild
        this.cmdImagesDirectory = new Gtk.Button();
        this.cmdImagesDirectory.CanFocus = true;
        this.cmdImagesDirectory.Name = "cmdImagesDirectory";
        this.cmdImagesDirectory.UseUnderline = true;
        this.cmdImagesDirectory.Label = Mono.Unix.Catalog.GetString("Browse");
        this.hbox3.Add(this.cmdImagesDirectory);
        Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox3[this.cmdImagesDirectory]));
        w6.Position = 2;
        w6.Expand = false;
        w6.Fill = false;
        this.vbox2.Add(this.hbox3);
        Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
        w7.Position = 0;
        w7.Expand = false;
        w7.Fill = false;
        // Container child vbox2.Gtk.Box+BoxChild
        this.hbox4 = new Gtk.HBox();
        this.hbox4.Name = "hbox4";
        this.hbox4.Spacing = 6;
        // Container child hbox4.Gtk.Box+BoxChild
        this.label2 = new Gtk.Label();
        this.label2.Name = "label2";
        this.label2.LabelProp = Mono.Unix.Catalog.GetString("Calibration/Robot design file");
        this.hbox4.Add(this.label2);
        Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox4[this.label2]));
        w8.Position = 0;
        w8.Expand = false;
        w8.Fill = false;
        // Container child hbox4.Gtk.Box+BoxChild
        this.txtCalibrationFilename = new Gtk.TextView();
        this.txtCalibrationFilename.CanFocus = true;
        this.txtCalibrationFilename.Name = "txtCalibrationFilename";
        this.hbox4.Add(this.txtCalibrationFilename);
        Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox4[this.txtCalibrationFilename]));
        w9.Position = 1;
        // Container child hbox4.Gtk.Box+BoxChild
        this.cmdCalibrationFilename = new Gtk.Button();
        this.cmdCalibrationFilename.CanFocus = true;
        this.cmdCalibrationFilename.Name = "cmdCalibrationFilename";
        this.cmdCalibrationFilename.UseUnderline = true;
        this.cmdCalibrationFilename.Label = Mono.Unix.Catalog.GetString("Browse");
        this.hbox4.Add(this.cmdCalibrationFilename);
        Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.hbox4[this.cmdCalibrationFilename]));
        w10.Position = 2;
        w10.Expand = false;
        w10.Fill = false;
        this.vbox2.Add(this.hbox4);
        Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
        w11.Position = 1;
        w11.Expand = false;
        w11.Fill = false;
        // Container child vbox2.Gtk.Box+BoxChild
        this.hbox5 = new Gtk.HBox();
        this.hbox5.Name = "hbox5";
        this.hbox5.Spacing = 6;
        // Container child hbox5.Gtk.Box+BoxChild
        this.label3 = new Gtk.Label();
        this.label3.Name = "label3";
        this.label3.LabelProp = Mono.Unix.Catalog.GetString("Calculation Time (mS)");
        this.hbox5.Add(this.label3);
        Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.hbox5[this.label3]));
        w12.Position = 0;
        w12.Expand = false;
        w12.Fill = false;
        // Container child hbox5.Gtk.Box+BoxChild
        this.txtStereoCorrespondenceTime = new Gtk.TextView();
        this.txtStereoCorrespondenceTime.CanFocus = true;
        this.txtStereoCorrespondenceTime.Name = "txtStereoCorrespondenceTime";
        this.hbox5.Add(this.txtStereoCorrespondenceTime);
        Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hbox5[this.txtStereoCorrespondenceTime]));
        w13.Position = 1;
        this.vbox2.Add(this.hbox5);
        Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox5]));
        w14.Position = 2;
        w14.Expand = false;
        w14.Fill = false;
        this.hbox2.Add(this.vbox2);
        Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.hbox2[this.vbox2]));
        w15.Position = 0;
        // Container child hbox2.Gtk.Box+BoxChild
        this.vbox3 = new Gtk.VBox();
        this.vbox3.Name = "vbox3";
        this.vbox3.Spacing = 6;
        // Container child vbox3.Gtk.Box+BoxChild
        this.cmdPrevious = new Gtk.Button();
        this.cmdPrevious.CanFocus = true;
        this.cmdPrevious.Name = "cmdPrevious";
        this.cmdPrevious.UseUnderline = true;
        this.cmdPrevious.Label = Mono.Unix.Catalog.GetString("Previous");
        this.vbox3.Add(this.cmdPrevious);
        Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox3[this.cmdPrevious]));
        w16.Position = 0;
        w16.Expand = false;
        w16.Fill = false;
        // Container child vbox3.Gtk.Box+BoxChild
        this.cmdNext = new Gtk.Button();
        this.cmdNext.CanFocus = true;
        this.cmdNext.Name = "cmdNext";
        this.cmdNext.UseUnderline = true;
        this.cmdNext.Label = Mono.Unix.Catalog.GetString("Next");
        this.vbox3.Add(this.cmdNext);
        Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.vbox3[this.cmdNext]));
        w17.Position = 1;
        w17.Expand = false;
        w17.Fill = false;
        this.hbox2.Add(this.vbox3);
        Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.hbox2[this.vbox3]));
        w18.Position = 2;
        w18.Expand = false;
        w18.Fill = false;
        this.vbox1.Add(this.hbox2);
        Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
        w19.Position = 1;
        w19.Expand = false;
        w19.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.hbox1 = new Gtk.HBox();
        this.hbox1.Name = "hbox1";
        this.hbox1.Spacing = 6;
        // Container child hbox1.Gtk.Box+BoxChild
        this.picLeftImage = new Gtk.Image();
        this.picLeftImage.Name = "picLeftImage";
        this.hbox1.Add(this.picLeftImage);
        Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.hbox1[this.picLeftImage]));
        w20.Position = 0;
        w20.Expand = false;
        w20.Fill = false;
        // Container child hbox1.Gtk.Box+BoxChild
        this.picRightImage = new Gtk.Image();
        this.picRightImage.Name = "picRightImage";
        this.hbox1.Add(this.picRightImage);
        Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.hbox1[this.picRightImage]));
        w21.Position = 1;
        w21.Expand = false;
        w21.Fill = false;
        this.vbox1.Add(this.hbox1);
        Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
        w22.Position = 2;
        w22.Expand = false;
        w22.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.picDepthMap = new Gtk.Image();
        this.picDepthMap.Name = "picDepthMap";
        this.vbox1.Add(this.picDepthMap);
        Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.vbox1[this.picDepthMap]));
        w23.Position = 3;
        w23.Expand = false;
        w23.Fill = false;
        this.Add(this.vbox1);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 641;
        this.DefaultHeight = 451;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
        this.Exit.Activated += new System.EventHandler(this.OnExitActivated);
        this.Low.Activated += new System.EventHandler(this.OnLowActivated);
        this.Medium.Activated += new System.EventHandler(this.OnMediumActivated);
        this.High.Activated += new System.EventHandler(this.OnHighActivated);
        this.DepthMap.Activated += new System.EventHandler(this.OnDepthMapActivated);
        this.SimpleStereo.Activated += new System.EventHandler(this.OnSimpleStereoActivated);
        this.cmdImagesDirectory.Clicked += new System.EventHandler(this.OnCmdImagesDirectoryClicked);
        this.cmdCalibrationFilename.Clicked += new System.EventHandler(this.OnCmdCalibrationFilenameClicked);
        this.cmdPrevious.Clicked += new System.EventHandler(this.OnCmdPreviousClicked);
        this.cmdNext.Clicked += new System.EventHandler(this.OnCmdNextClicked);
    }
}
