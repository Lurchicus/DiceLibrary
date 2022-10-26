# DiceLibrary 1.0.11.0

By Dan Rhea (aka Lurchicus) 9/30/2022 (updated: 10/25/2022)

Written in C# 10.0 for .NET 6.0

This class library contains some utility methods for throwing 1 to MAX_DIES
dice with 1 to MAX_SIDES sides and have an adjustment that can be
added to the final result. You can return the final result or a single collective
object or a list of objects containing details for each die (documented below).

The limit of 1000 is an artifical one imposed to try and keep memory
usage to a reasonable level. You can up the limit by cloneing and
modifying the source code and recompiling the library. The value is 
defined in Max.MAX_DIES and Max.MAX_SIDES in Dies.cs

Dice with 1 or 2 sides are a special "coin toss" mode where a value of 
1 indicates you can throw a 1 or 0 on any given throw. A Value of 2 is the
same, but will throw a 1 or 2.

The class library by design allows you to specify dice that would be 
impossible or at least improbable (like a 3 sided die).

The program also has a method that accepts a dice notation string to
designate quantity, sides and adjustments like "3D6+1" by using a built 
in parser (private method Parse) I created.

I'm kind of winging it on documenting the library methods. I'll 
improve it as I see more examples. I also plan on eventually putting
the library in a NuGet package.

RollDies - Create, roll dice and return the result.

	int RollDies(int Quantity, int Sides, int Adjustment)

	- int: Quantity - Number of dice to "throw" (1:MAX_DIES)
	- int: Sides - Number of sides on a die (1:MAX_SIDES)
	- int: Adjustment: Adjustment to apply to the total result (+/- int) 

	Returns the total of all dice thrown including the adjustment.

RollDiesToDie - Create, roll dice and return a single dice object (Dies)

	static public Dies RollDiesToDie(int Quantity, int Sides, int Adjustment)

	- int: Quantity - Number of dice to "throw" (1:MAX_DIES)
	- int: Sides - Number of sides on a die (1:MAX_SIDES)
	- int: Adjustment: Adjustment to apply to the total result (+/- int) 

	Returns the total of all dice in a dice object (Dies)

RollDetails - Create, roll dice and return a list structure of all dice throws.

	List<Dies> RollDetails(int Quantity, int Sides, int Adjustment)

	- int: Quantity - Number of dice to "throw" (1:MAX_DIES)
	- int: Sides - Number of sides on a die (1:MAX_SIDES)
	- int: Adjustment: Adjustment to apply to the total result (+/- int) 

	Returns a list of "Dies" objects of all dice thrown (see below for dies structure)

ParseDAndD - Parses dice notation string into quantity, side and adjustment'

	public bool ParseDAndD(string Cmd, ref int Quantity, ref int Sides, ref int Adjustment)

	- string: Cmd Dice notation string (quantityDsides[[+|-]adjustment], I.E. 3d20-3)
	- ref int: Quantity - Number of dice to "throw" (1:MAX_DIES)
	- ref int: Sides - Number of sides on a die (1:MAX_SIDES)
	- ref int: Adjustment: Adjustment to apply to the total result (+/- int)

	Returns a bool. True for a good parse and false for a bad parse. A bad parse
	will force a return of 1d6 values which is the default

RollDAndD - Take a dice notation string to determine what dice we need to throw and throw them

	int RollDAndD(string RollCommand)

	- string: RollCommand - Dice notation string (quantityDsides[[+|-]adjustment], I.E. 1D6+1)

		Quantity and sides are still limited to 1 to 1000 (MAX_DIES and MAX_SIDES).

	Returns the total of all dice thrown including the adjustment.

RollDAndDToDie - Given dice syntax string, roll the dies but return the results in a single "dies" object

	Dies RollDAndDToDie(string RollCommand)

	- string: RollCommand - Dice notation string (quantityDsides[[+|-]adjustment], I.E. 1D6+1)

		Quantity and sides are still limited to 1 to 1000 (MAX_DIES and MAX_SIDES).

	Returns the total of all dice in a dice object (Dies)

RollDAndDDetails - Given dice syntax string, create, roll dice and return a list of every die thrown.

	List<Dies> RollDAndDDetails(string RollCommand)

	- string: RollCommand - Dice notation string (quantityDsides[[+|-]adjustment], I.E. 1D6+1)

		Quantity and sides are still limited to 1 to 1000 (MAX_DIES and MAX_SIDES).

	Returns a list of "Dies" objects of all dice thrown (see below for dies structure)

MITLicense - Returns a string containing the formatted MIT license

	public string MITLicense()

	Returns a string containing the formatted MIT license

Dies object structure (a single die class object)

	- int: Id - Numeric id of and individual die
	- int: Qty - Number of dies being thrown
	- int: Sides - Number of sides on a die (a value of 0 or 1 does a coin flip (0 or 1 | 1 or 2)
	- int: Adjustment - Numeric adjustment (positive or negative) applied to the final total
	- int: Result - The throw result of just "this" die.
	- int: Total - Running total of all throws

Max class contains the constants for MAX_DIES and MAX_SIDES.
