using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManchesterUnited
{
    internal class Player
    {
        public string NombreApellido;
        public int JerseyNumber;
        public int Goals;
        public int PointsInSpeed;
        public int PointsInAssist;
        public int PointsInPassingAccuracy;
        public int DefensiveInvolvements;

        public Player(string nombreapellido, int jerseyNumber, int goals, int pointsInSpeed, int pointsInAssist, int pointsInPassingAccuracy, int defensiveInvolvements)
        {
            NombreApellido = nombreapellido;
            JerseyNumber = jerseyNumber;
            Goals = goals;
            PointsInSpeed = pointsInSpeed;
            PointsInAssist = pointsInAssist;
            PointsInPassingAccuracy = pointsInPassingAccuracy;
            DefensiveInvolvements = defensiveInvolvements;
        }
    }
}
