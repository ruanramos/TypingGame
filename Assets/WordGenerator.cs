using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

    private static string[] wordList = {
                                        "Faculdade", "Trabalhos", "Monografia", "TCC", "Graduação", "Professor", "Mestrado", "Doutorado", "Prova", "Acadêmico",
                                        "Prova Final", "PF", "P1", "P2", "P3", "Livro", "Xerox", "Apostila", "Cansaço", "Desespero", "Desesperança", "Tristeza",
                                        "Almoço", "Lanche", "Bandeijão", "Fila", "Kilo", "Amigos", "Amizade", "Estudo", "Festas", "Bebida", "Centro Acadêmico",
                                        "Álcool", "Drogas", "Miçanga", "Humanas", "Exatas", "Cálculo", "Diploma", "Colação", "Formatura", "Maconha", "Assalto",
                                        "Sequestro", "Ônibus", "Passagem", "Estacionamento", "Assalto", "Ansiedade", "Depressão", "Esperança", "Futuro",
                                        "Trabalho", "Profissão", "Objetivo", "Vontade", "Esforço", "Café", "Guaraná", "Energético", "Madrugada", "Sono", "Insônia",
                                        "Distúrbios", "Colegas", "Grupo", "Salário", "Iniciação Científica", "Carreira", "Sustento", "República", "Perrengue",
                                        "Slides", "Caderno", "Caneta", "Cola", "Nerd", "CR", "Empresa", "Estágio", "Entrevista", "Dinâmica de Grupo", "Currículo",
                                        "Anexo", "Email", "Lista", "Avaliação", "Teste", "Carona", "Whatsapp", "Telegram", "Ajuda", "Monitoria", "Bolsa", "Universidade",
                                        "Universitário", "Ciclo Básico", "Viagem", "Viagem de Campo", "Projeto", "Extensão", "Coordenador", "Orientador", "Sala",
                                        "Turma", "Disciplina", "Matéria", "Inscrição", "SIGA", "CRID", "CRPID", "Van", "Trânsito", "Engarrafamento", "Laboratório",
                                        "Computador", "Defeito", "Chatisse", "Secretaria", "Processo", "Matrícula", "Travamento", "Greve", "Férias", "Música",
                                        "Latex", "Capa Dura", "Apresentação", "Atraso", "Prazos", "Dissertação", "Tutorial", "Google", "Wikipedia", "Acabando",
                                        "Votação", "Sindicato", "Grêmio Estudantil", "Corredor", "Bloco", "Moedas", "Bilhete", "Ingresso", "Pagamento", "Satisfação", "Capacidade",
                                        "Incapacidade", "Reconhecimento", "Aprendizado", "Desistência", "Fim de Semana", "Não Vou", "Não Posso", "Notebook", "Projetor",
                                        "Datas", "Preconceito", "Vestibular", "ENEM", "Cotas", "Esquemas", "Funcionários", "Servidores", "Salgado", "Refresco", "Pastel",
                                        "Open Bar", "Conclusão", "Crescimento", "Pública", "Privada", "Substituto", "Terceirizado", "Calouro", "Veterano", "Aprovado",
                                        "Reprovado", "Atlética", "Esportes", "Atividades", "Classe", "Remédios", "Trancamento", "Autorização", "Conversa", "Tensão",
                                        "Doenças", "Superação", "Problemas Pessoais", "Sociedade", "Animais Abandonados", "Roupa Social", "Aniversários", "Vômito",
                                        "Sonhos", "Pesadelos", "Energia", "Economia", "Mudança de Curso", "Despreparo", "Preparo", "Dúvida", "Certeza", "Incerteza",
                                        "Planejamento", "Imprevistos", "Organização", "Especialização", "Falhas", "Infra-Estrutura"
                                        };

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }

}
