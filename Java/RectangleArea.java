package scannerpractices;
import java.util.Scanner;
public class RectangleArea {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter Length: ");
		int a = sc.nextInt();
		System.out.print("Enter Breadth: ");
		int b = sc.nextInt();
		System.out.print("Area of Rectangle: "+ (a*b));
	}
}
