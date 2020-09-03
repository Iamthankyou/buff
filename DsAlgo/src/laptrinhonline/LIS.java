package laptrinhonline;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class LIS {
	private ArrayList<Integer> res;
	private int n;
	
	public int process() {
		try(Scanner sc = new Scanner(System.in)){
			n = sc.nextInt();
			res = new ArrayList<>();
			res.add(1<<31);
			
			for (int i=0; i<n; i++) {
				int x = sc.nextInt();
				
				if (res.get(res.size()-1)<x) {
					res.add(x);
				}
				else {
					int pos = Collections.binarySearch(res, x);
					
					if (pos<0) {
						pos = -(pos+1);
					}
					
					if (pos>=res.size()) {
						res.add(x);
					}
					else {
						res.set(pos, x);
					}
				}
			}
		}
		catch(Exception e) {
			e.printStackTrace();
		}
		
		System.out.println(res);
		
		return res.size()-1;
	}
	
	public static void main(String args[]) {
		LIS lis = new LIS();
		
		System.out.println(lis.process());
	}
}
