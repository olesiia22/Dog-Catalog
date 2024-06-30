using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private DogCatalog catalog;

    public Form1()
    {
        InitializeComponent();
        catalog = new DogCatalog("dogbreeds.txt");
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        string name = txtDogName.Text.Trim();
        DogBreed breed = catalog.FindBreed(name);
        if (breed != null)
        {
            breed.DisplayInfo(txtDogInfo);
        }
        else
        {
            txtDogInfo.Text = "Breed not found.";
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        var newBreed = new CustomBreed(txtNewBreedName.Text.Trim(), txtDescription.Text, txtEnvironment.Text, txtDiet.Text, txtFeedingSchedule.Text, txtEthology.Text, txtUseCase.Text, txtCoexistence.Text);
        catalog.AddBreed(newBreed);
        MessageBox.Show("Breed added successfully.");
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        string name = txtDogName.Text.Trim();
        catalog.RemoveBreed(name);
        MessageBox.Show("Breed removed successfully.");
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        var updatedBreed = new CustomBreed(txtNewBreedName.Text.Trim(), txtDescription.Text, txtEnvironment.Text, txtDiet.Text, txtFeedingSchedule.Text, txtEthology.Text, txtUseCase.Text, txtCoexistence.Text);
        catalog.UpdateBreed(txtNewBreedName.Text.Trim(), updatedBreed);
        MessageBox.Show("Breed updated successfully.");
    }
}
