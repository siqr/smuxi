// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Smuxi.Frontend.Gnome {
    
    
    public partial class EngineAssistantNameWidget {
        
        private Gtk.VBox vbox2;
        
        private Gtk.VBox vbox3;
        
        private Gtk.Label f_EngineNameLabel;
        
        private Gtk.Entry f_EngineNameEntry;
        
        private Gtk.Label label2;
        
        private Gtk.VBox vbox4;
        
        private Gtk.Label label7;
        
        private Gtk.CheckButton f_MakeDefaultEngineCheckButton;
        
        private Gtk.Label label8;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Smuxi.Frontend.Gnome.EngineAssistantNameWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "Smuxi.Frontend.Gnome.EngineAssistantNameWidget";
            // Container child Smuxi.Frontend.Gnome.EngineAssistantNameWidget.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 10;
            this.vbox2.BorderWidth = ((uint)(5));
            // Container child vbox2.Gtk.Box+BoxChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.f_EngineNameLabel = new Gtk.Label();
            this.f_EngineNameLabel.Name = "f_EngineNameLabel";
            this.f_EngineNameLabel.Xalign = 0F;
            this.f_EngineNameLabel.LabelProp = Mono.Unix.Catalog.GetString("_Engine Name:");
            this.f_EngineNameLabel.UseUnderline = true;
            this.vbox3.Add(this.f_EngineNameLabel);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox3[this.f_EngineNameLabel]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.f_EngineNameEntry = new Gtk.Entry();
            this.f_EngineNameEntry.CanFocus = true;
            this.f_EngineNameEntry.Name = "f_EngineNameEntry";
            this.f_EngineNameEntry.IsEditable = true;
            this.f_EngineNameEntry.InvisibleChar = '●';
            this.vbox3.Add(this.f_EngineNameEntry);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox3[this.f_EngineNameEntry]));
            w2.Position = 1;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.Xpad = 50;
            this.label2.Xalign = 0F;
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("<span size=\"small\">Profile name of the new engine</span>");
            this.label2.UseMarkup = true;
            this.vbox3.Add(this.label2);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox3[this.label2]));
            w3.Position = 2;
            w3.Expand = false;
            w3.Fill = false;
            this.vbox2.Add(this.vbox3);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox2[this.vbox3]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.vbox4 = new Gtk.VBox();
            this.vbox4.Name = "vbox4";
            this.vbox4.Spacing = 6;
            this.vbox4.BorderWidth = ((uint)(5));
            // Container child vbox4.Gtk.Box+BoxChild
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.Xalign = 0F;
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("_Default Engine:");
            this.label7.UseUnderline = true;
            this.vbox4.Add(this.label7);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox4[this.label7]));
            w5.Position = 0;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.f_MakeDefaultEngineCheckButton = new Gtk.CheckButton();
            this.f_MakeDefaultEngineCheckButton.CanFocus = true;
            this.f_MakeDefaultEngineCheckButton.Name = "f_MakeDefaultEngineCheckButton";
            this.f_MakeDefaultEngineCheckButton.Label = Mono.Unix.Catalog.GetString("Use as new default engine");
            this.f_MakeDefaultEngineCheckButton.DrawIndicator = true;
            this.f_MakeDefaultEngineCheckButton.UseUnderline = true;
            this.vbox4.Add(this.f_MakeDefaultEngineCheckButton);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox4[this.f_MakeDefaultEngineCheckButton]));
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.label8 = new Gtk.Label();
            this.label8.Name = "label8";
            this.label8.Xpad = 50;
            this.label8.Xalign = 0F;
            this.label8.LabelProp = Mono.Unix.Catalog.GetString("<span size=\"small\">If enabled this makes the current engine the default when starting Smuxi next time</span>");
            this.label8.UseMarkup = true;
            this.label8.Wrap = true;
            this.vbox4.Add(this.label8);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox4[this.label8]));
            w7.Position = 2;
            w7.Expand = false;
            w7.Fill = false;
            this.vbox2.Add(this.vbox4);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox2[this.vbox4]));
            w8.Position = 1;
            w8.Expand = false;
            w8.Fill = false;
            this.Add(this.vbox2);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.f_EngineNameLabel.MnemonicWidget = this.f_EngineNameEntry;
            this.label7.MnemonicWidget = this.f_MakeDefaultEngineCheckButton;
            this.Hide();
        }
    }
}