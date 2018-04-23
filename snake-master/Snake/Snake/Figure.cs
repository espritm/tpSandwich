using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Figure
	{
		protected List<Point> pList;

		public void Draw()
		{
            //mon commentaire
			// draw lines
            //dessine les lignes
			foreach ( Point p in pList )
			{
				p.Draw();
			}
		}

		internal bool IsHit( Figure figure )
		{
			foreach(var p in pList)
			{
				if ( figure.IsHit( p ) )
					return true;
			}
			return false;
		}
        // I dont understand
		private bool IsHit( Point point )
		{
			foreach(var p in pList)
			{
				if ( p.IsHit( point ) )
					return true;
			}
			return false;
		}
	}
}
