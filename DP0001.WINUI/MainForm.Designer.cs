namespace DP0001.WINUI
{
    partial class MainForm
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
            this.gbEnrollment = new System.Windows.Forms.GroupBox();
            this.MaxFingers = new System.Windows.Forms.NumericUpDown();
            this.Mask = new System.Windows.Forms.NumericUpDown();
            this.EnrollButton = new System.Windows.Forms.Button();
            this.gbEventHandlerStatus = new System.Windows.Forms.GroupBox();
            this.IsFailure = new System.Windows.Forms.RadioButton();
            this.IsSuccess = new System.Windows.Forms.RadioButton();
            this.lblMaxFingers = new System.Windows.Forms.Label();
            this.lblMask = new System.Windows.Forms.Label();
            this.gbVerification = new System.Windows.Forms.GroupBox();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.gbReturnValues = new System.Windows.Forms.GroupBox();
            this.FalseAcceptRate = new System.Windows.Forms.TextBox();
            this.lblFalseAcceptRate = new System.Windows.Forms.Label();
            this.IsFeatureSetMatched = new System.Windows.Forms.CheckBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbEnrollment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFingers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mask)).BeginInit();
            this.gbEventHandlerStatus.SuspendLayout();
            this.gbVerification.SuspendLayout();
            this.gbReturnValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEnrollment
            // 
            this.gbEnrollment.Controls.Add(this.MaxFingers);
            this.gbEnrollment.Controls.Add(this.Mask);
            this.gbEnrollment.Controls.Add(this.EnrollButton);
            this.gbEnrollment.Controls.Add(this.gbEventHandlerStatus);
            this.gbEnrollment.Controls.Add(this.lblMaxFingers);
            this.gbEnrollment.Controls.Add(this.lblMask);
            this.gbEnrollment.Location = new System.Drawing.Point(14, 14);
            this.gbEnrollment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbEnrollment.Name = "gbEnrollment";
            this.gbEnrollment.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbEnrollment.Size = new System.Drawing.Size(310, 232);
            this.gbEnrollment.TabIndex = 0;
            this.gbEnrollment.TabStop = false;
            this.gbEnrollment.Text = "Enrollment";
            // 
            // MaxFingers
            // 
            this.MaxFingers.Location = new System.Drawing.Point(187, 60);
            this.MaxFingers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaxFingers.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxFingers.Name = "MaxFingers";
            this.MaxFingers.Size = new System.Drawing.Size(110, 23);
            this.MaxFingers.TabIndex = 3;
            this.ToolTip.SetToolTip(this.MaxFingers, "Enter a number from 1 to 10");
            this.MaxFingers.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Mask
            // 
            this.Mask.Location = new System.Drawing.Point(187, 31);
            this.Mask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Mask.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.Mask.Name = "Mask";
            this.Mask.Size = new System.Drawing.Size(110, 23);
            this.Mask.TabIndex = 1;
            this.ToolTip.SetToolTip(this.Mask, "Enter a number from 0 to 1023");
            // 
            // EnrollButton
            // 
            this.EnrollButton.Location = new System.Drawing.Point(85, 187);
            this.EnrollButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EnrollButton.Name = "EnrollButton";
            this.EnrollButton.Size = new System.Drawing.Size(125, 27);
            this.EnrollButton.TabIndex = 5;
            this.EnrollButton.Text = "Enroll Fingerprints";
            this.ToolTip.SetToolTip(this.EnrollButton, "Start fingerprint enrollment");
            this.EnrollButton.UseVisualStyleBackColor = true;
            this.EnrollButton.Click += new System.EventHandler(this.EnrollButton_Click);
            // 
            // gbEventHandlerStatus
            // 
            this.gbEventHandlerStatus.Controls.Add(this.IsFailure);
            this.gbEventHandlerStatus.Controls.Add(this.IsSuccess);
            this.gbEventHandlerStatus.Location = new System.Drawing.Point(10, 91);
            this.gbEventHandlerStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbEventHandlerStatus.Name = "gbEventHandlerStatus";
            this.gbEventHandlerStatus.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbEventHandlerStatus.Size = new System.Drawing.Size(293, 69);
            this.gbEventHandlerStatus.TabIndex = 4;
            this.gbEventHandlerStatus.TabStop = false;
            this.gbEventHandlerStatus.Text = "Event handler status";
            // 
            // IsFailure
            // 
            this.IsFailure.AutoSize = true;
            this.IsFailure.Location = new System.Drawing.Point(176, 33);
            this.IsFailure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IsFailure.Name = "IsFailure";
            this.IsFailure.Size = new System.Drawing.Size(60, 19);
            this.IsFailure.TabIndex = 1;
            this.IsFailure.TabStop = true;
            this.IsFailure.Text = "Failure";
            this.ToolTip.SetToolTip(this.IsFailure, "Force an enrollment failure");
            this.IsFailure.UseVisualStyleBackColor = true;
            // 
            // IsSuccess
            // 
            this.IsSuccess.AutoSize = true;
            this.IsSuccess.Location = new System.Drawing.Point(30, 33);
            this.IsSuccess.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IsSuccess.Name = "IsSuccess";
            this.IsSuccess.Size = new System.Drawing.Size(66, 19);
            this.IsSuccess.TabIndex = 0;
            this.IsSuccess.TabStop = true;
            this.IsSuccess.Text = "Success";
            this.ToolTip.SetToolTip(this.IsSuccess, "Allow a successful enrollment");
            this.IsSuccess.UseVisualStyleBackColor = true;
            // 
            // lblMaxFingers
            // 
            this.lblMaxFingers.Location = new System.Drawing.Point(7, 61);
            this.lblMaxFingers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxFingers.Name = "lblMaxFingers";
            this.lblMaxFingers.Size = new System.Drawing.Size(173, 23);
            this.lblMaxFingers.TabIndex = 2;
            this.lblMaxFingers.Text = "Max. enrolled fingers count";
            this.lblMaxFingers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMask
            // 
            this.lblMask.Location = new System.Drawing.Point(7, 31);
            this.lblMask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(173, 23);
            this.lblMask.TabIndex = 0;
            this.lblMask.Text = "Fingerprint Mask";
            this.lblMask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbVerification
            // 
            this.gbVerification.Controls.Add(this.VerifyButton);
            this.gbVerification.Controls.Add(this.gbReturnValues);
            this.gbVerification.Location = new System.Drawing.Point(14, 253);
            this.gbVerification.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbVerification.Name = "gbVerification";
            this.gbVerification.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbVerification.Size = new System.Drawing.Size(310, 237);
            this.gbVerification.TabIndex = 1;
            this.gbVerification.TabStop = false;
            this.gbVerification.Text = "Verification";
            // 
            // VerifyButton
            // 
            this.VerifyButton.Location = new System.Drawing.Point(85, 186);
            this.VerifyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(125, 27);
            this.VerifyButton.TabIndex = 1;
            this.VerifyButton.Text = "Verify Fingerprints";
            this.ToolTip.SetToolTip(this.VerifyButton, "Start fingerprint verification");
            this.VerifyButton.UseVisualStyleBackColor = true;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // gbReturnValues
            // 
            this.gbReturnValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReturnValues.Controls.Add(this.FalseAcceptRate);
            this.gbReturnValues.Controls.Add(this.lblFalseAcceptRate);
            this.gbReturnValues.Controls.Add(this.IsFeatureSetMatched);
            this.gbReturnValues.Location = new System.Drawing.Point(10, 46);
            this.gbReturnValues.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbReturnValues.Name = "gbReturnValues";
            this.gbReturnValues.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbReturnValues.Size = new System.Drawing.Size(293, 115);
            this.gbReturnValues.TabIndex = 0;
            this.gbReturnValues.TabStop = false;
            this.gbReturnValues.Text = "Return values";
            // 
            // FalseAcceptRate
            // 
            this.FalseAcceptRate.Location = new System.Drawing.Point(154, 72);
            this.FalseAcceptRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FalseAcceptRate.Name = "FalseAcceptRate";
            this.FalseAcceptRate.ReadOnly = true;
            this.FalseAcceptRate.Size = new System.Drawing.Size(131, 23);
            this.FalseAcceptRate.TabIndex = 2;
            this.ToolTip.SetToolTip(this.FalseAcceptRate, "Displays the false accept rate (FAR)");
            // 
            // lblFalseAcceptRate
            // 
            this.lblFalseAcceptRate.Location = new System.Drawing.Point(7, 72);
            this.lblFalseAcceptRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFalseAcceptRate.Name = "lblFalseAcceptRate";
            this.lblFalseAcceptRate.Size = new System.Drawing.Size(140, 23);
            this.lblFalseAcceptRate.TabIndex = 1;
            this.lblFalseAcceptRate.Text = "False accept rate";
            this.lblFalseAcceptRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IsFeatureSetMatched
            // 
            this.IsFeatureSetMatched.AutoCheck = false;
            this.IsFeatureSetMatched.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsFeatureSetMatched.Location = new System.Drawing.Point(7, 37);
            this.IsFeatureSetMatched.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IsFeatureSetMatched.Name = "IsFeatureSetMatched";
            this.IsFeatureSetMatched.Size = new System.Drawing.Size(162, 28);
            this.IsFeatureSetMatched.TabIndex = 0;
            this.IsFeatureSetMatched.Text = "Feature set matched?";
            this.ToolTip.SetToolTip(this.IsFeatureSetMatched, "Displays a match result");
            this.IsFeatureSetMatched.UseVisualStyleBackColor = true;
            // 
            // QuitButton
            // 
            this.QuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.QuitButton.Location = new System.Drawing.Point(237, 509);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(88, 27);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.ToolTip.SetToolTip(this.QuitButton, "Close the sample application");
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.QuitButton;
            this.ClientSize = new System.Drawing.Size(335, 549);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.gbVerification);
            this.Controls.Add(this.gbEnrollment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSharp UI Sample";
            this.gbEnrollment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaxFingers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mask)).EndInit();
            this.gbEventHandlerStatus.ResumeLayout(false);
            this.gbEventHandlerStatus.PerformLayout();
            this.gbVerification.ResumeLayout(false);
            this.gbReturnValues.ResumeLayout(false);
            this.gbReturnValues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnrollButton;
        private System.Windows.Forms.RadioButton IsFailure;
        private System.Windows.Forms.RadioButton IsSuccess;
        private System.Windows.Forms.TextBox FalseAcceptRate;
        private System.Windows.Forms.CheckBox IsFeatureSetMatched;
        private System.Windows.Forms.Button VerifyButton;
        private System.Windows.Forms.NumericUpDown MaxFingers;
        private System.Windows.Forms.NumericUpDown Mask;
        private System.Windows.Forms.ToolTip ToolTip;
        private GroupBox gbEnrollment;
        private GroupBox gbEventHandlerStatus;
        private Label lblMaxFingers;
        private Label lblMask;
        private GroupBox gbVerification;
        private GroupBox gbReturnValues;
        private Label lblFalseAcceptRate;
        private Button QuitButton;
    }
}