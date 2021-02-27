/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LinkedList;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.LinkedList;

/**
 *
 * @author BOSS
 */
public class Main {
    public static void main(String[] args) {
        LinkedList<Integer> list = new LinkedList<>();
        list.add(1);
        list.add(2);
        list.add(3);
        
        list.forEach(item -> {
            System.out.print(item + " ");
        });
        System.out.println("");
        Iterator<Integer> listIte = list.iterator();
        while(listIte.hasNext()) {
            System.out.print(listIte.next() + " ");
        }
    }
}
