using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class DogCatalog
{
    private List<DogBreed> breeds = new List<DogBreed>();
    private string filePath;

    public DogCatalog(string filePath)
    {
        this.filePath = filePath;
        LoadBreeds();
    }

    private void LoadBreeds()
    {
        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 8)
                {
                    var breed = new CustomBreed(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7]);
                    breeds.Add(breed);
                }
            }
        }
    }

    private void SaveBreeds()
    {
        var lines = breeds.Select(b => $"{b.Name}|{b.Description}|{b.Environment}|{b.Diet}|{b.FeedingSchedule}|{b.Ethology}|{b.UseCase}|{b.Coexistence}");
        File.WriteAllLines(filePath, lines);
    }

    public DogBreed FindBreed(string name)
    {
        return breeds.FirstOrDefault(b => b.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void AddBreed(DogBreed breed)
    {
        breeds.Add(breed);
        SaveBreeds();
    }

    public void RemoveBreed(string name)
    {
        var breed = FindBreed(name);
        if (breed != null)
        {
            breeds.Remove(breed);
            SaveBreeds();
        }
    }

    public void UpdateBreed(string name, DogBreed updatedBreed)
    {
        var breed = FindBreed(name);
        if (breed != null)
        {
            breeds.Remove(breed);
            breeds.Add(updatedBreed);
            SaveBreeds();
        }
    }
}
