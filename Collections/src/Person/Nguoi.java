/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Person;

import java.util.Objects;

/**
 *
 * @author BOSS
 */
public class Nguoi implements Comparable<Nguoi>{
    private String soCMND;
    private String ten;
    private int tuoi;

    public Nguoi(String soCMND, String ten, int tuoi) {
        this.soCMND = soCMND;
        this.ten = ten;
        this.tuoi = tuoi;
    }

    public Nguoi(String soCMND) {
        this.soCMND = soCMND;
    }

    public String getTen() {
        return ten;
    }

    public int getTuoi() {
        return tuoi;
    }
    

    @Override
    public String toString() {
        return "Nguoi{" + "soCMND=" + soCMND + ", ten=" + ten + ", tuoi=" + tuoi + '}';
    }

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
        final Nguoi other = (Nguoi) obj;
        if (!Objects.equals(this.soCMND, other.soCMND)) {
            return false;
        }
        return true;
    }

    @Override
    public int compareTo(Nguoi o) {
        return tuoi - o.tuoi;
    }
    
    
}
