from Pessoa import Pessoa

class Aluno(Pessoa):
    def __init__(self, nome = '', idade = 0, curso = ''):
        Pessoa.__init__(self, nome, idade)
        self.curso = curso


    def imprimir(self):
        print("Dados do Aluno:")
        print("Nome = " + str(self.nome))
        print("Idade = " + str(self.idade))
        print("Curso = " + str(self.curso))
