class Retangulo(object):

    #construtor
    def __init__(self, base, altura):
        self.basE = base
        self.alturA = altura
    #metodo area
    def area(self):
        areA = self.basE * self.alturA
        print(areA)
    #metodo perimetro
    def perimetro(self):
        perimetrO = 2*(self.basE + self.alturA)
        print(perimetrO)
