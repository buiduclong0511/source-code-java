/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Array;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.Iterator;
import java.util.Scanner;

/**
 *
 * @author BOSS
 */
public class Main {
    static ArrayList<Integer> arr = new ArrayList<Integer>();
    
            
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        nhapDaySo();
        System.out.print("Mang vua nhap la: ");
        inDaySo();
        System.out.println("Phan tu nho nhat trong day so: " + timMin());
        sapDaySo();
        System.out.print("Day so sau khi sap xep la: ");
        inDaySo();
        while(true) {
            System.out.print("Nhap vao index can xoa: ");
            int index = sc.nextInt();
            if (xoaPhanTu(index)) {
                System.out.println("Day sao sau khi xoa: ");
                inDaySo();
                break;
            } else {
                System.out.println("Vi tri khong hop le!");
            }
        }
    }

    private static void nhapDaySo() {
        Scanner sc = new Scanner(System.in);
        int i, dem = 0;
        while(dem < 10) {
            System.out.print("i = ");
            i = sc.nextInt();
            if (arr.contains(i)) {
                System.out.println("Da xuat hien phan tu nay trong mang");
            } else {
                arr.add(i);
                dem++;
            }
        }
    }

    private static void inDaySo() {
        Iterator<Integer> iterator = arr.iterator();
        while(iterator.hasNext()) {
            System.out.print(iterator.next() + " ");
        }
        System.out.println("");
    }

    private static int timMin() {
        return Collections.min(arr);
    }

    private static void sapDaySo() {
        Collections.sort(arr);
    }

    private static boolean xoaPhanTu(int index) {
        if (index >= 0 && index <= arr.size()) {
            arr.remove(index);
            return true;
        } else {
            return false;
        }
    }
}
