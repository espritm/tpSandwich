using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class DevModeLine : Figure
	{
		public DevModeLine(int xLeft, int xRight, int y, char sym)
		{
			pList = new List<Point>();
			for(int x = xLeft; x <= xRight; x++)
			{
				Point p = new Point( x, y, sym );
				pList.Add( p );
			}

            pList[xRight / 2 - 4].sym = 'D';
            pList[xRight / 2 - 3].sym = 'e';
            pList[xRight / 2 - 2].sym = 'v';
            pList[xRight / 2 - 1].sym = ' ';
            pList[xRight / 2 + 0].sym = 'm';
            pList[xRight / 2 + 1].sym = 'o';
            pList[xRight / 2 + 2].sym = 'd';
            pList[xRight / 2 + 3].sym = 'e';
        }
	}
}
