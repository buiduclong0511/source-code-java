/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ArrayList;

import java.util.ArrayList;
import java.util.Scanner;

/**
 *
 * @author BOSS
 */
public class Main {
    public static void main(String[] args) {
        ArrayList<Cat> cats = new ArrayList<>();
        Cat c1 = new Cat("Den");
        Cat c2 = new Cat("Vang");
        cats.add(c1);
        cats.add(c2);
        Scanner sc = new Scanner(System.in);
        Cat c3 = new Cat(sc.nextLine());
        
        if (!cats.contains(c3)) {
            cats.add(c3);
        }
        
        System.out.println(cats);
    }
}
