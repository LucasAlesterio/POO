class Retangulo(object):

    #construtor
    def __init__(self, base, altura):
        self.basE = int(base)
        self.alturA = int(altura)
    #metodo area
    def area(self):
        areA = self.basE * self.alturA
        print(areA)
    #metodo perimetro
    def perimetro(self):
        perimetrO = 2*(self.basE + self.alturA)
        print(perimetrO)

rec = Retangulo(2, 8)
rec.area()
rec.perimetro()