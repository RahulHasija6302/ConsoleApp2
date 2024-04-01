using System;

public class Class1
{
	public void test1()
	{
		Console.WriteLine("This is a public method");
	}
	private void test2()
	{
		Console.WriteLine("This is a private method");
	}
	protected void test3()
	{
		Console.WriteLine("This is a protected method");
	}
	internal void test4()
	{
		Console.WriteLine("This is a internal method");
	}
	protected internal void test5()
	{
		Console.WriteLine("This is a protected internal method");
	}

	static void Main(string[] args)
	{
		Class1 cl = new Class1();
		cl.test1();
		cl.test2();
		cl.test3();
		cl.test4();
		cl.test5();
		Console.ReadLine();
	}

}
