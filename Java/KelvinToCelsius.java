package scannerpractices;
import java.util.Scanner;
public class KelvinToCelsius {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter Celsius: ");
		float kelv = sc.nextInt();
		
		float cel = kelv - 273.15f;
		System.out.print("Converted Kelvin is: "+cel);
		

	}

}
