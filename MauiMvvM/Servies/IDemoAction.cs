using System;
using System.Collections.Generic;
using System.Text;

namespace MauiMvvM.Servies
{
    public interface IDemoAction
    {
        public void BuildBedroom();
        
        public void IsKitchen();

        public int GetLivingRoomSize();

        public Color GetBathRoom();
    }
}
