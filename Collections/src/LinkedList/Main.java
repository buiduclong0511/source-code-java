/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LinkedList;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Iterator;
import java.util.LinkedList;

/**
 *
 * @author BOSS
 */
public class Main {
    public static void main(String[] args) {
        LinkedList<Student> students = new LinkedList<>();
        students.add(new Student("Long", 21));
        students.add(new Student("Cường", 20));
        
        students.addFirst(new Student("Nam", 23));
        students.addLast(new Student("Hoàng", 19));
        
        
        for(int i = 0; i < students.size(); i++) {
            System.out.println(students.get(i));
        }
        
        Collections.sort(students);
        
        System.out.println("danh sach sau khi sap xep:");
        Iterator<Student> studentIte = students.iterator();
        while(studentIte.hasNext()) {
            System.out.println(studentIte.next());
        }
    }
}
