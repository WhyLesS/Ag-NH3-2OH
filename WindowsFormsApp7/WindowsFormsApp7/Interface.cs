using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public interface IHaveHP
    {
        int hp { get; set; }
    }

    interface IHaveDefend : IHaveHP
    {
        int defend { get; set; }
        string Defender(Sundew sundew);
    }

    interface ISunflower : IPlant
    {
        string HealSundew(Sundew sundew, Sun sun);
        string HealNut(Nut nut, Sun sun);
    }

    interface IPlant : IHaveHP
    {
        string AreLife();
        string GetPhotoEating(Sun sun);
    }

    interface ISundew : IPlant
    {
        string GetPlotFromHuman(Human human);
    }

    interface IHuman : IHaveHP
    {
        string EatFood();
        string ReadBook();
        string Kills(object obj);
        string MeLife();
    }

    interface ISuperHuman
    {
        string KillAll(Human human, Sundew sundew, Sunflower sunflower, Nut nut);
    }

    interface INut :  IHaveDefend 
    {
        string Strengthen();
    }
}
