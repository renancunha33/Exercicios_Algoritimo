
public class Main {

	public static void main(String[] args) {
		int vet2[] = { 1, 3, 5, 7, 9 };
		int vet1[] = { 0, 2, 4, 6, 8 };
		int vet3[] = new int[10];
		int num = 0, num2 = 1;
		for (int i = 0; i < 5; i++) {
			vet3[num] = vet1[i];
			vet3[num2] = vet2[i];
			num = num + 2;
			num2 = num2 + 2;

		}
		for (int a = 0; a < 10; a++) {
			System.out.println(vet3[a]);
		}

	}

}
