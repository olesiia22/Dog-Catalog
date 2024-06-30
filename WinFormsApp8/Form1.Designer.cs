partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private ToolTip toolTip;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.toolTip = new ToolTip(this.components);

        this.txtDogName = new System.Windows.Forms.TextBox();
        this.txtDogInfo = new System.Windows.Forms.TextBox();
        this.btnSearch = new System.Windows.Forms.Button();
        this.btnAdd = new System.Windows.Forms.Button();
        this.btnRemove = new System.Windows.Forms.Button();
        this.btnUpdate = new System.Windows.Forms.Button();
        this.txtNewBreedName = new System.Windows.Forms.TextBox();
        this.txtDescription = new System.Windows.Forms.TextBox();
        this.txtEnvironment = new System.Windows.Forms.TextBox();
        this.txtDiet = new System.Windows.Forms.TextBox();
        this.txtFeedingSchedule = new System.Windows.Forms.TextBox();
        this.txtEthology = new System.Windows.Forms.TextBox();
        this.txtUseCase = new System.Windows.Forms.TextBox();
        this.txtCoexistence = new System.Windows.Forms.TextBox();

        this.SuspendLayout();

        // txtDogName
        this.txtDogName.Location = new System.Drawing.Point(12, 12);
        this.txtDogName.Name = "txtDogName";
        this.txtDogName.Size = new System.Drawing.Size(260, 20);
        this.txtDogName.TabIndex = 0;

        // txtDogInfo
        this.txtDogInfo.Location = new System.Drawing.Point(12, 38);
        this.txtDogInfo.Multiline = true;
        this.txtDogInfo.Name = "txtDogInfo";
        this.txtDogInfo.Size = new System.Drawing.Size(260, 150);
        this.txtDogInfo.TabIndex = 1;

        // btnSearch
        this.btnSearch.Location = new System.Drawing.Point(278, 10);
        this.btnSearch.Name = "btnSearch";
        this.btnSearch.Size = new System.Drawing.Size(75, 23);
        this.btnSearch.TabIndex = 2;
        this.btnSearch.Text = "Search";
        this.btnSearch.UseVisualStyleBackColor = true;
        this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

        // btnAdd
        this.btnAdd.Location = new System.Drawing.Point(278, 194);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(75, 23);
        this.btnAdd.TabIndex = 3;
        this.btnAdd.Text = "Add";
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

        // btnRemove
        this.btnRemove.Location = new System.Drawing.Point(278, 223);
        this.btnRemove.Name = "btnRemove";
        this.btnRemove.Size = new System.Drawing.Size(75, 23);
        this.btnRemove.TabIndex = 4;
        this.btnRemove.Text = "Remove";
        this.btnRemove.UseVisualStyleBackColor = true;
        this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

        // btnUpdate
        this.btnUpdate.Location = new System.Drawing.Point(278, 252);
        this.btnUpdate.Name = "btnUpdate";
        this.btnUpdate.Size = new System.Drawing.Size(75, 23);
        this.btnUpdate.TabIndex = 5;
        this.btnUpdate.Text = "Update";
        this.btnUpdate.UseVisualStyleBackColor = true;
        this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

        // txtNewBreedName
        this.txtNewBreedName.Location = new System.Drawing.Point(12, 194);
        this.txtNewBreedName.Name = "txtNewBreedName";
        this.txtNewBreedName.Size = new System.Drawing.Size(260, 20);
        this.txtNewBreedName.TabIndex = 6;

        // txtDescription
        this.txtDescription.Location = new System.Drawing.Point(12, 220);
        this.txtDescription.Name = "txtDescription";
        this.txtDescription.Size = new System.Drawing.Size(260, 20);
        this.txtDescription.TabIndex = 7;

        // txtEnvironment
        this.txtEnvironment.Location = new System.Drawing.Point(12, 246);
        this.txtEnvironment.Name = "txtEnvironment";
        this.txtEnvironment.Size = new System.Drawing.Size(260, 20);
        this.txtEnvironment.TabIndex = 8;

        // txtDiet
        this.txtDiet.Location = new System.Drawing.Point(12, 272);
        this.txtDiet.Name = "txtDiet";
        this.txtDiet.Size = new System.Drawing.Size(260, 20);
        this.txtDiet.TabIndex = 9;

        // txtFeedingSchedule
        this.txtFeedingSchedule.Location = new System.Drawing.Point(12, 298);
        this.txtFeedingSchedule.Name = "txtFeedingSchedule";
        this.txtFeedingSchedule.Size = new System.Drawing.Size(260, 20);
        this.txtFeedingSchedule.TabIndex = 10;

        // txtEthology
        this.txtEthology.Location = new System.Drawing.Point(12, 324);
        this.txtEthology.Name = "txtEthology";
        this.txtEthology.Size = new System.Drawing.Size(260, 20);
        this.txtEthology.TabIndex = 11;

        // txtUseCase
        this.txtUseCase.Location = new System.Drawing.Point(12, 350);
        this.txtUseCase.Name = "txtUseCase";
        this.txtUseCase.Size = new System.Drawing.Size(260, 20);
        this.txtUseCase.TabIndex = 12;

        // txtCoexistence
        this.txtCoexistence.Location = new System.Drawing.Point(12, 376);
        this.txtCoexistence.Name = "txtCoexistence";
        this.txtCoexistence.Size = new System.Drawing.Size(260, 20);
        this.txtCoexistence.TabIndex = 13;

        // Tooltips
        toolTip.SetToolTip(txtNewBreedName, "Enter the breed name");
        toolTip.SetToolTip(txtDescription, "Enter the breed description");
        toolTip.SetToolTip(txtEnvironment, "Enter the preferred environment for the breed");
        toolTip.SetToolTip(txtDiet, "Enter the diet for the breed");
        toolTip.SetToolTip(txtFeedingSchedule, "Enter the feeding schedule for the breed");
        toolTip.SetToolTip(txtEthology, "Enter the ethology (behavior) of the breed");
        toolTip.SetToolTip(txtUseCase, "Enter the typical use case for the breed");
        toolTip.SetToolTip(txtCoexistence, "Enter how well the breed coexists with other animals");

        // Form1
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(365, 410);
        this.Controls.Add(this.txtCoexistence);
        this.Controls.Add(this.txtUseCase);
        this.Controls.Add(this.txtEthology);
        this.Controls.Add(this.txtFeedingSchedule);
        this.Controls.Add(this.txtDiet);
        this.Controls.Add(this.txtEnvironment);
        this.Controls.Add(this.txtDescription);
        this.Controls.Add(this.txtNewBreedName);
        this.Controls.Add(this.btnUpdate);
        this.Controls.Add(this.btnRemove);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.btnSearch);
        this.Controls.Add(this.txtDogInfo);
        this.Controls.Add(this.txtDogName);
        this.Name = "Form1";
        this.Text = "Dog Catalog";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox txtDogName;
    private System.Windows.Forms.TextBox txtDogInfo;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.TextBox txtNewBreedName;
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.TextBox txtEnvironment;
    private System.Windows.Forms.TextBox txtDiet;
    private System.Windows.Forms.TextBox txtFeedingSchedule;
    private System.Windows.Forms.TextBox txtEthology;
    private System.Windows.Forms.TextBox txtUseCase;
    private System.Windows.Forms.TextBox txtCoexistence;
}
