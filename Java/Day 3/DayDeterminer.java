package scannerpractices;
import java.util.Scanner;
public class DayDeterminer {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.print("Enter a number (1-7): ");
		int a = sc.nextInt();
		System.out.print((a < 1 || a > 7) ? "Invalid Number" : (a == 1 || a == 7) ? "Weekend" : "Weekday");
	}
}