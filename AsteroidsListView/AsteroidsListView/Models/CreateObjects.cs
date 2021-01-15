using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace AsteroidsListView.Models
{
    public class CreateObjects
    {
        public ObservableCollection<SpaceObject> AllObjects { get; set; }
        public CreateObjects()
        {
            AllObjects = new ObservableCollection<SpaceObject>();
            AllObjects.Add(new SpaceObject { Name = "Merkur", Type = "Planeta", Age = 4.503 });
            AllObjects.Add(new SpaceObject { Name = "Venuše", Type = "Planeta", Age = 4.503 });
            AllObjects.Add(new SpaceObject { Name = "Země", Type = "Planeta", Age = 4.543 });
            AllObjects.Add(new SpaceObject { Name = "Mars", Type = "Planeta", Age = 4.603 });
            AllObjects.Add(new SpaceObject { Name = "Jupiter", Type = "Planeta", Age = 4.503 });
            AllObjects.Add(new SpaceObject { Name = "Saturn", Type = "Planeta", Age = 4.503 });
            AllObjects.Add(new SpaceObject { Name = "Uran", Type = "Planeta", Age = 4.503 });
            AllObjects.Add(new SpaceObject { Name = "Neptun", Type = "Planeta", Age = 4.503 });
        }
    }
}
