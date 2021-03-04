/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package LinkedList;

import java.util.Objects;

/**
 *
 * @author TieuLong
 */
public class Student implements Comparable<Student>{
    private String name;
    private int age;
    

    @Override
    public boolean equals(Object obj) {
        if (this == obj) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (getClass() != obj.getClass()) {
            return false;
        }
        final Student other = (Student) obj;
        if (this.age != other.age) {
            return false;
        }
        if (!Objects.equals(this.name, other.name)) {
            return false;
        }
        return true;
    }

    public Student() {
    }

    public Student(String name, int age) {
        this.name = name;
        this.age = age;
    }

    @Override
    public String toString() {
        return "Student{" + "name=" + name + ", age=" + age + '}';
    }

    public int getAge() {
        return age;
    }

   

    

    @Override
    public int compareTo(Student o) {
        if (age > o.age) {
            return 1;
        } else if (age < o.age) {
            return -1;
        } else {
            return 0;
        }
//        return age - o.age;
    }
}
