/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package chimse_ga;

/**
 *
 * @author BOSS
 */
public class Sparrow extends Animal implements Flyable{

    @Override
    void grow() {
//        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
        super.weight += 0.3;
    }

    @Override
    public void fly() {
//        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
        System.out.println("I can fly");
    }

    public Sparrow() {
        super();
    }
    
    public Sparrow(String name, double weight) {
        super(name, weight);
    }
}
