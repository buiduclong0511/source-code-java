/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LinkedList;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
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
        
        System.out.println("danh sach sau khi sap xep tuoi tang dan:");
        Iterator<Student> studentIte = students.iterator();
        while(studentIte.hasNext()) {
            System.out.println(studentIte.next());
        }
        
        Collections.sort(students, new Comparator<Student>(){
            @Override
            public int compare(Student o1, Student o2) {
                if (o2.getAge() > o1.getAge()) {
                    return 1;
                } else if (o2.getAge() < o1.getAge()) {
                    return -1;
                } else {
                    return 0;
                }
            }
        
        });
        
        System.out.println("danh sach sau khi sap xep tuoi giam dan:");
        
        students.forEach(student -> {
            System.out.println(student);
        });
    }
}
