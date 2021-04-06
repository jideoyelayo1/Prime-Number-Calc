import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	// write your code here
        System.out.println("Enter n: ");
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        List<Integer> listOfNums = Range(1, n);
        List<Integer> listOfPrimes = primeNums(listOfNums);
        for(int i = 0; i < listOfPrimes.size();i++)
        System.out.println(listOfPrimes.get(i));;
        System.out.println("the Number of primes is: " + listOfPrimes.size() );
    }
    public static List<Integer> Range(int a, int b)
    {
        List<Integer> nums = new ArrayList<Integer>();
        for(int i = a; i  <= b;i++)
            nums.add(i);
        return nums;
    }

    public static List<Integer> primeNums(List<Integer> nums)
    {
        List<Integer> ans = new ArrayList<Integer>();
        int prime = 0;
        int i;
        while (nums.size() > 1)
        {
            if (nums.get(1) == 1)
                nums.remove(0);
            i = 0;
            prime = nums.get(1);
            ans.add(nums.get(1));
            while (i<nums.size())
            {
                if(nums.get(i) % prime == 0)
                    nums.remove(i);
                i++;
            }

        }

        return ans;
    }
}
