import { Veiculo } from "./Veiculo";

export interface Personagem{
  id: number;
  nome: string;
  carteira: number;

  veiculos: Veiculo[];
}
