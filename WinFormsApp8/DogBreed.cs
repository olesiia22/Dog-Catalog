public abstract class DogBreed
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Environment { get; set; }
    public string Diet { get; set; }
    public string FeedingSchedule { get; set; }
    public string Ethology { get; set; }
    public string UseCase { get; set; }
    public string Coexistence { get; set; }

    public DogBreed() { }

    public DogBreed(string name, string description, string environment, string diet, string feedingSchedule, string ethology, string useCase, string coexistence)
    {
        Name = name;
        Description = description;
        Environment = environment;
        Diet = diet;
        FeedingSchedule = feedingSchedule;
        Ethology = ethology;
        UseCase = useCase;
        Coexistence = coexistence;
    }

    public virtual void DisplayInfo(TextBox textBox)
    {
        textBox.Text = $"Breed: {Name}\nDescription: {Description}\nEnvironment: {Environment}\nDiet: {Diet}\nFeeding Schedule: {FeedingSchedule}\nEthology: {Ethology}\nUse Case: {UseCase}\nCoexistence: {Coexistence}";
    }
}
