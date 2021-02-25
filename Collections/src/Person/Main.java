/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Person;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Iterator;

/**
 *
 * @author BOSS
 */
public class Main {
    static ArrayList<Nguoi> list = new ArrayList<Nguoi>();
    
    static void nhapDS() {
        Nguoi p1 = new Nguoi("001", "Long", 20);
        Nguoi p2 = new Nguoi("002", "Long1", 21);
        Nguoi p3 = new Nguoi("003", "Long2", 19);
        Nguoi p4 = new Nguoi("004", "Long3", 21);
        list.add(p1);
        list.add(p2);
        list.add(p3);
        list.add(p4);
    }
    
    static void inDS() {
        Iterator<Nguoi> iterator = list.iterator();
        while(iterator.hasNext()) {
            System.out.println("\t" + iterator.next());
        }
    }
    
    static void sapXep() {
        Collections.sort(list);
    }
    
    public static void main(String[] args) {
        nhapDS();
        System.out.println("Danh sach vua nhap: ");
        inDS();
        sapXep();
        System.out.println("Dach sau khi sap xep theo tuoi la: ");
        inDS();
    }
}
