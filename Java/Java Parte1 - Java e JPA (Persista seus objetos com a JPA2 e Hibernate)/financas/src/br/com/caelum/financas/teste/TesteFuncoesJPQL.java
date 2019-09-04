package br.com.caelum.financas.teste;

import java.math.BigDecimal;
import java.util.List;

import javax.persistence.*;

import br.com.caelum.financas.dao.MovimentacaoDao;
import br.com.caelum.financas.modelo.Conta;
import br.com.caelum.financas.modelo.Movimentacao;
import br.com.caelum.financas.modelo.TipoMovimentacao;
import br.com.caelum.financas.util.JPAUtil;

public class TesteFuncoesJPQL {
	
	public static void main(String[] args) {
	    EntityManager em = new JPAUtil().getEntityManager();
	    em.getTransaction().begin();
	    
	    Conta conta  = new Conta();
        conta.setId(2);

        //MovimentacaoDao dao = new MovimentacaoDao(em);
        //List<Double> medias = dao.getMediasPorDiaETipo(TipoMovimentacao.SAIDA, conta);
        
        TypedQuery<Double> typedQuery = em.createNamedQuery("MediasPorDiaETipo", Double.class);

        typedQuery.setParameter("pConta", conta);
        typedQuery.setParameter("pTipo", TipoMovimentacao.SAIDA);

        List<Double> medias = typedQuery.getResultList();
        
	    System.out.println("A soma do dia 04 é: " + medias.get(0));
	    System.out.println("A soma do dia 05 é: " + medias.get(1));
	    System.out.println("A soma do dia 26 é: " + medias.get(2));
	    System.out.println("A soma do dia 27 é: " + medias.get(3));
	    
	    em.getTransaction().commit();
	    em.close();
	}
}
