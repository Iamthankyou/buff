package laptrinhonline;

import java.util.Scanner;

public class MClosestTriangle {
	public class Pair{
		private double first,second;
		
		public Pair(double first, double second) {
			this.first = first;
			this.second = second;
		}
		
		public double getFirst() {
			return first;
		}
		
		public double getSecond() {
			return second;
		}
		
		public void setFirst(double first) {
			this.first = first;
		}
		
		public void setSecond(double second) {
			this.second = second;
		}

	}
	
	private Pair a,b,c,m;
	
//	public MClosestTriangle(Pair a, Pair b, Pair c, Pair m) {
//		this.a = a;
//		this.b = b;
//		this.c = c;
//		this.m = m;
//	}
	
	public MClosestTriangle(double xa, double ya, double xb, double yb, double xc, double yc, double xm, double ym) {
		a = new Pair(xa,ya);
		b = new Pair(xb,yb);
		c = new Pair(xc,yc);
		m = new Pair(xm,ym);
	}
	
	public double distance(Pair a, Pair b) {
		return Math.pow(a.getFirst()-b.getFirst(),2)+Math.pow(a.getSecond()-b.getSecond(),2);
	}
	
	public Pair find(Pair aa, Pair bb, Pair m) {
		Pair mid = null;
		
		while (Math.abs(aa.getFirst()-bb.getFirst())>1e-5 || Math.abs(aa.getSecond()-bb.getSecond())>1e-5) {
			mid = new Pair((aa.getFirst()+bb.getFirst())/2,((aa.getSecond()+bb.getSecond())/2));

			//ystem.out.println(Math.abs(aa.first-bb.first));
			double l = distance(aa,m);
			double r = distance(bb,m);
			
			if (l>r) {
				aa=mid;
			}
			else {
//				System.out.println(bb.getFirst()+"?");
				bb=mid;
//				System.out.println(bb.getFirst());
			}
		}

		return mid;
	}
	
	public double area(Pair a, Pair b, Pair c) {
		return Math.abs((b.getFirst()-a.getFirst())*(c.getSecond()-a.getSecond()-(c.getFirst()-a.getFirst())*(b.getSecond()-a.getSecond())))/2;
	}
	
	public double min(double a, double b, double c) {
		return a>b&&a>c?a:b>c?b:c;
	}
	
	public Pair process() {
		System.out.println(a.getFirst()+" "+a.getSecond());
		System.out.println(b.getFirst()+" "+b.getSecond());
		System.out.println(c.getFirst()+" "+c.getSecond());
		System.out.println(m.getFirst()+" "+m.getSecond());
		
		if (area(a,b,c) == area(a,b,m)+area(a,c,m)+area(c,b,m)) {
			return m;
		}
		else {
			Pair x = find(a,b,m);
//			System.out.println(x.getFirst()+" "+x.getSecond());
			Pair y = find(a,c,m);
//			System.out.println(y.getFirst()+" "+y.getSecond());
			Pair z = find(c,b,m);
//			System.out.println(z.getFirst()+" "+z.getSecond());

			double best = min(distance(x,m),distance(y,m),distance(z,m));
			
			if (best == distance(x,m)) {
				return x;
			}
			else if (best == distance(y,m)) {
				return y;
			}
			else {
				return z;
			}
		}
	}
	
	public static void main(String args[]) {
		MClosestTriangle closest;
		
		try(Scanner sc = new Scanner(System.in)){
			int t = sc.nextInt();
			
			for (int i=0; i<t; i++) {
				double xa = sc.nextDouble();
				double ya = sc.nextDouble();
				double xb = sc.nextDouble();
				double yb = sc.nextDouble();	
				double xc = sc.nextDouble();
				double yc = sc.nextDouble();
				double xm = sc.nextDouble();
				double ym = sc.nextDouble();
				
				closest = new MClosestTriangle(xa,ya,xb,yb,xc,yc,xm,ym);
				Pair res = closest.process();
				System.out.println(res.getFirst()+" "+res.getSecond());
			}
		}
		catch(Exception e) {
			e.printStackTrace();
		}
	}
}
