class Tempo(object):
#Construtor
    def __init__(self,hora,min,seg):
        self.hora = int(hora)
        self.min = int(min)
        self.seg = int(seg)
    def entrada(self):
        self.hora = int(input('Entre com a hora: '))
        self.min = int(input('Entre com o minuto: '))
        self.seg = int(input('Entre com os segundos: '))
#getters setters?
    def imprime(self):
        print(self.hora + ":" + self.min + ":" + self.seg)

    def soma(self,Tempo,t2):
        flag = False
        self.seg = self.seg + t2.seg
        if(self.seg>=60):
            flag = True
            self.seg = self.seg - 60
        self.min = self.min + t2.min
        if(flag):
            flag = False
            self.min + 1
        if(self.min >= 60):
            flag = True
            self.min - 60
        self.hora = self.hora + t2.hora
        if(flag):
            flag = False
            self.hora + 1

    def sub(self,Tempo,t2):
        flag = False
        if(t2.seg > self.seg):
            self.seg = self.seg + 60 - t2.seg
            flag = True
        else:
            self.seg = self.seg - t2.seg
            
        if(flag):
            self.min = self.min - 1
            flag = False
        if(t2.min > self.min):
            self.min = self.min + 60 - t2.min
            flag = True
        else:
            self.min = self.min - t2.min
        if(flag):
            self.hora = self.hora - 1
            flag = False
        if(t2.hora > self.hora):
            print("ERRO!(Hora de entrada maior que a de saida)")
            self.hora = 0
        else:
            self.hora = self.hora - t2.hora

class Estacionamento(object):
    def __init__(self,placa,Tempo, marca , valor):
        self.placa = str(placa)
        self.marca = str(marca)
        self.valor = int(valor)
    def cadastro(self,Tempo, timein , timeout):
        self.placa = input('Entre com a placa do carro: ')
        self.marca = input('Entre com o marca do carro: ')
        print("Hora de entrada: ")
        timein.entrada()
        print("Hora de saida: ")
        timeout.entrada()
    def imprimecar(self):
        print("Marca:" + self.marca + ", placa:" + self.placa)
    def cobrar(self,Time,timein,timeout,teste):
        timeout.sub(t1,timein)
        self.valor = int(timeout.hora * 7)
        if(teste):
            print("O valor do estacionamento é: " + str(self.valor))
    def matriz(self,Time,timein,timeout):
        tabela = []
        x = 5
        for i in range(x):
            tabela.append([])
            p[i].cadastro(t1,timein,timeout)
            tabela[i].append(p.marca)
            tabela[i].append(p.placa)
            tabela[i].append(timein.hora)
            tabela[i].append(timein.min)
            tabela[i].append(timein.seg)
            tabela[i].append(timeout.hora)
            tabela[i].append(timeout.min)
            tabela[i].append(timeout.seg)
            p.cobrar(t1,timein,timeout,False)
            tabela[i].append(p.valor)
        #imprimir
        print("Marca:    |Placa:     |Hora:(in)  |Min:(in) |Seg:(in) |Hora:(out) |Min:(out) |Seg:(out) |Valor total: ")
        quant_linhas = len(tabela)
        quant_colunas = len(tabela[0])
        for i in range(quant_linhas):
            print("\n")
            for j in range(quant_colunas):
                print(str(tabela[i][j]) + "          ",end="")
        print("\n")
           
        
t1 = Tempo(0,0,0)
timein = Tempo(0,0,0)
timeout = Tempo(0,0,0)
teste = True
p = Estacionamento(0,t1,0,0)
p.cadastro(t1,timein,timeout)
p.imprimecar()
p.cobrar(t1,timein,timeout,teste)
print("Entre com os dados da matriz: ")
p.matriz(t1,timein,timeout)





