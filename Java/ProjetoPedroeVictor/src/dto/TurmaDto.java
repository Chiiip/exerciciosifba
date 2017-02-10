/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package dto;

/**
 *
 * @author Pedro Augusto
 */
public class TurmaDto {
private int codturma;
private String nometurma;
private String turno;

    /**
     * @return the codturma
     */
    public int getCodturma() {
        return codturma;
    }

    /**
     * @param codturma the codturma to set
     */
    public void setCodturma(int codturma) {
        this.codturma = codturma;
    }

    /**
     * @return the nometurma
     */
    public String getNometurma() {
        return nometurma;
    }

    /**
     * @param nometurma the nometurma to set
     */
    public void setNometurma(String nometurma) {
        this.nometurma = nometurma;
    }

    /**
     * @return the turno
     */
    public String getTurno() {
        return turno;
    }

    /**
     * @param turno the turno to set
     */
    public void setTurno(String turno) {
        this.turno = turno;
    }

}
