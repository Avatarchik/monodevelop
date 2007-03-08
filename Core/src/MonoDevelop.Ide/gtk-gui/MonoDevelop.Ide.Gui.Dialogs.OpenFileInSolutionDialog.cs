// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.Ide.Gui.Dialogs {
    
    
    public partial class OpenFileInSolutionDialog {
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox hbox1;
        
        private Gtk.ToggleButton toggleFiles;
        
        private Gtk.ToggleButton toggleTypes;
        
        private Gtk.ScrolledWindow scrolledwindow2;
        
        private Gtk.TreeView tree;
        
        private Gtk.HBox hbox2;
        
        private Gtk.Label label1;
        
        private Gtk.Entry matchEntry;
        
        private Gtk.Button cancelButton;
        
        private Gtk.Button openButton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize();
            // Widget MonoDevelop.Ide.Gui.Dialogs.OpenFileInSolutionDialog
            this.Events = ((Gdk.EventMask)(256));
            this.Name = "MonoDevelop.Ide.Gui.Dialogs.OpenFileInSolutionDialog";
            this.Title = Mono.Unix.Catalog.GetString("Open File in Solution");
            // Internal child MonoDevelop.Ide.Gui.Dialogs.OpenFileInSolutionDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Events = ((Gdk.EventMask)(256));
            w1.Name = "dialog_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog_VBox.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            this.vbox2.BorderWidth = ((uint)(6));
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.toggleFiles = new Gtk.ToggleButton();
            this.toggleFiles.CanFocus = true;
            this.toggleFiles.Name = "toggleFiles";
            this.toggleFiles.UseUnderline = true;
            this.toggleFiles.UseUnderline = true;
            this.toggleFiles.Active = true;
            this.toggleFiles.Label = Mono.Unix.Catalog.GetString("Search _Files");
            this.hbox1.Add(this.toggleFiles);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.toggleFiles]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.toggleTypes = new Gtk.ToggleButton();
            this.toggleTypes.CanFocus = true;
            this.toggleTypes.Name = "toggleTypes";
            this.toggleTypes.UseUnderline = true;
            this.toggleTypes.UseUnderline = true;
            this.toggleTypes.Label = Mono.Unix.Catalog.GetString("Search _Types");
            this.hbox1.Add(this.toggleTypes);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.toggleTypes]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            this.vbox2.Add(this.hbox1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.scrolledwindow2 = new Gtk.ScrolledWindow();
            this.scrolledwindow2.CanFocus = true;
            this.scrolledwindow2.Name = "scrolledwindow2";
            this.scrolledwindow2.VscrollbarPolicy = ((Gtk.PolicyType)(1));
            this.scrolledwindow2.HscrollbarPolicy = ((Gtk.PolicyType)(1));
            this.scrolledwindow2.ShadowType = ((Gtk.ShadowType)(3));
            // Container child scrolledwindow2.Gtk.Container+ContainerChild
            this.tree = new Gtk.TreeView();
            this.tree.CanFocus = true;
            this.tree.Name = "tree";
            this.scrolledwindow2.Add(this.tree);
            this.vbox2.Add(this.scrolledwindow2);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox2[this.scrolledwindow2]));
            w6.Position = 1;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("_Name:");
            this.label1.UseUnderline = true;
            this.hbox2.Add(this.label1);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox2[this.label1]));
            w7.Position = 0;
            w7.Expand = false;
            w7.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.matchEntry = new Gtk.Entry();
            this.matchEntry.CanFocus = true;
            this.matchEntry.Name = "matchEntry";
            this.matchEntry.IsEditable = true;
            this.matchEntry.InvisibleChar = '●';
            this.hbox2.Add(this.matchEntry);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox2[this.matchEntry]));
            w8.Position = 1;
            this.vbox2.Add(this.hbox2);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
            w9.Position = 2;
            w9.Expand = false;
            w9.Fill = false;
            w1.Add(this.vbox2);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(w1[this.vbox2]));
            w10.Position = 0;
            // Internal child MonoDevelop.Ide.Gui.Dialogs.OpenFileInSolutionDialog.ActionArea
            Gtk.HButtonBox w11 = this.ActionArea;
            w11.Events = ((Gdk.EventMask)(256));
            w11.Name = "MonoDevelop.Ide.OpenFileInSolutionDialog_ActionArea";
            w11.Spacing = 10;
            w11.BorderWidth = ((uint)(5));
            w11.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child MonoDevelop.Ide.OpenFileInSolutionDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.cancelButton = new Gtk.Button();
            this.cancelButton.CanDefault = true;
            this.cancelButton.CanFocus = true;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseStock = true;
            this.cancelButton.UseUnderline = true;
            this.cancelButton.Label = "gtk-cancel";
            this.AddActionWidget(this.cancelButton, -6);
            Gtk.ButtonBox.ButtonBoxChild w12 = ((Gtk.ButtonBox.ButtonBoxChild)(w11[this.cancelButton]));
            w12.Expand = false;
            w12.Fill = false;
            // Container child MonoDevelop.Ide.OpenFileInSolutionDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.openButton = new Gtk.Button();
            this.openButton.CanDefault = true;
            this.openButton.CanFocus = true;
            this.openButton.Name = "openButton";
            this.openButton.UseStock = true;
            this.openButton.UseUnderline = true;
            this.openButton.Label = "gtk-open";
            this.AddActionWidget(this.openButton, 0);
            Gtk.ButtonBox.ButtonBoxChild w13 = ((Gtk.ButtonBox.ButtonBoxChild)(w11[this.openButton]));
            w13.Position = 1;
            w13.Expand = false;
            w13.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 690;
            this.DefaultHeight = 356;
            this.Show();
            this.Shown += new System.EventHandler(this.HandleShown);
            this.toggleFiles.Clicked += new System.EventHandler(this.OnToggleFilesClicked);
            this.toggleTypes.Clicked += new System.EventHandler(this.OnToggleTypesClicked);
            this.tree.RowActivated += new Gtk.RowActivatedHandler(this.HandleRowActivate);
            this.matchEntry.KeyPressEvent += new Gtk.KeyPressEventHandler(this.HandleKeyPress);
            this.matchEntry.Changed += new System.EventHandler(this.HandleEntryChanged);
            this.matchEntry.Activated += new System.EventHandler(this.HandleEntryActivate);
            this.openButton.Clicked += new System.EventHandler(this.HandleOpen);
        }
    }
}
