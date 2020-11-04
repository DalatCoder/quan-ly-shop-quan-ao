namespace WebQuanAo_Demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
			this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
			this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
			this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.SuspendLayout();
			// 
			// fluentDesignFormContainer1
			// 
			this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fluentDesignFormContainer1.Location = new System.Drawing.Point(173, 31);
			this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
			this.fluentDesignFormContainer1.Size = new System.Drawing.Size(389, 395);
			this.fluentDesignFormContainer1.TabIndex = 0;
			// 
			// accordionControl1
			// 
			this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
			this.accordionControl1.Location = new System.Drawing.Point(0, 31);
			this.accordionControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.accordionControl1.Name = "accordionControl1";
			this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
			this.accordionControl1.Size = new System.Drawing.Size(173, 395);
			this.accordionControl1.TabIndex = 1;
			this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
			// 
			// accordionControlElement1
			// 
			this.accordionControlElement1.Name = "accordionControlElement1";
			this.accordionControlElement1.Text = "Element1";
			// 
			// fluentDesignFormControl1
			// 
			this.fluentDesignFormControl1.FluentDesignForm = this;
			this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
			this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
			this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
			this.fluentDesignFormControl1.Size = new System.Drawing.Size(562, 31);
			this.fluentDesignFormControl1.TabIndex = 2;
			this.fluentDesignFormControl1.TabStop = false;
			// 
			// fluentFormDefaultManager1
			// 
			this.fluentFormDefaultManager1.DockingEnabled = false;
			this.fluentFormDefaultManager1.Form = this;
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(562, 426);
			this.ControlContainer = this.fluentDesignFormContainer1;
			this.Controls.Add(this.fluentDesignFormContainer1);
			this.Controls.Add(this.accordionControl1);
			this.Controls.Add(this.fluentDesignFormControl1);
			this.FluentDesignFormControl = this.fluentDesignFormControl1;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.NavigationControl = this.accordionControl1;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
	}
}

