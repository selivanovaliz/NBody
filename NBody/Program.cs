﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBody
{
	class Program
	{

		[STAThread]
		static void Main(string[] args)
		{
			using (var game = new NBody())
			{
				game.Parameters.TrackObjects = true;
				game.Run(args);
			}
		}
	}
}
