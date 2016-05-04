package main;

import java.awt.Color;
import java.awt.Container;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import negocio.Calculo;

public class Formulario {

    Calculo cal = new Calculo();
    private JFrame frmPrincipal;
    private JLabel valor1;
    private JLabel valor2;
    private JTextField txtvl1;
    private JTextField txtvl2;
    private JButton btnsoma;
    private JButton btnsub;
    private JButton btnvezes;
    private JButton btndiv;

    public Formulario() {
        InicializarComponentes();
    }

    private void InicializarComponentes() {

        frmPrincipal = new JFrame("Formulário principal");
        frmPrincipal.setBounds(300, 200, 400, 300); // (x=300, y=200, larg.=400, alt.=150)
        frmPrincipal.setLayout(null);
        frmPrincipal.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Container painel = frmPrincipal.getContentPane();
        Font minhaFonte = new Font("Arial", Font.ITALIC, 12);

        valor1 = new JLabel("Valor 1: ");

        valor1.setBounds(30, 20, 70, 20);

        valor1.setFont(minhaFonte);

        valor1.setForeground(Color.BLACK);

        painel.add(valor1);

        valor2 = new JLabel("Valor 2: ");

        valor2.setBounds(30, 20, 70, 80);

        valor2.setFont(minhaFonte);

        valor2.setForeground(Color.black);

        painel.add(valor2);

        txtvl1 = new JTextField();

        txtvl1.setBounds(100, 15, 250, 30);

        txtvl1.setFont(minhaFonte);
        painel.add(txtvl1);
        txtvl2 = new JTextField();

        txtvl2.setBounds(100, 50, 250, 30);

        txtvl2.setFont(minhaFonte);
        painel.add(txtvl2);

        btnsoma = new JButton("somar");

        btnsoma.setBounds(100, 90, 250, 30);

        btnsoma.setFont(minhaFonte);

        btnsoma.setEnabled(true);

        btnsoma.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent ae) {
                JOptionPane.showMessageDialog(null, cal.Somar(Integer.parseInt(txtvl1.getText()), Integer.parseInt(txtvl2.getText())));
            }

        });
        // adiciona botão à área de conteúdo do formulário
        painel.add(btnsoma);

        btnsub = new JButton("sub");

        btnsub.setBounds(100, 130, 250, 30);

        btnsub.setFont(minhaFonte);

        btnsub.setEnabled(true);

        btnsub.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent ae) {
                JOptionPane.showMessageDialog(null, cal.Subtrair(Integer.parseInt(txtvl1.getText()), Integer.parseInt(txtvl2.getText())));
            }

        });
        // adiciona botão à área de conteúdo do formulário
        painel.add(btnsub);

        btnvezes = new JButton("multiplicar");

        btnvezes.setBounds(100, 170, 250, 30);

        btnvezes.setFont(minhaFonte);

        btnvezes.setEnabled(true);

        btnvezes.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent ae) {
                JOptionPane.showMessageDialog(null, cal.Multiplicar(Integer.parseInt(txtvl1.getText()), Integer.parseInt(txtvl2.getText())));
            }

        });
        painel.add(btnvezes);

        btndiv = new JButton("dividir");

        btndiv.setBounds(100, 210, 250, 30);

        btndiv.setFont(minhaFonte);

        btndiv.setEnabled(true);

        btndiv.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent ae) {
                JOptionPane.showMessageDialog(null, cal.Dividir(Integer.parseInt(txtvl1.getText()), Integer.parseInt(txtvl2.getText())));
            }

        });

        painel.add(btndiv);

        frmPrincipal.setVisible(true);

    }

}
