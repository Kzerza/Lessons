﻿//
//  Program.cs
//
//  Author:
//       KaShin <qanton@gmail.com>
//
//  Copyright (c) 2016 KaShin
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;

namespace Lessons
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] intArray = new int[10];
			int a = 0;

			Console.Write ("Increment\n");
			for (int x = 0; x < 10; x++) {
				intArray [x] = a++;
				Console.WriteLine (intArray [x]);
			}

			Console.Write ("Decrement\n");
			a = 0;
			for (int x = 0; x < 10; x++) {
				intArray [x] = ++a;
				Console.WriteLine (intArray [x]);
			}
		}
	}
}
