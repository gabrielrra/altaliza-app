import { Categoria } from "./Categoria";

export interface Veiculo {
  id: number;
  nome: string;
  categoriaId: number;
  estoque: number;
  imagem: string;
  preco1dia: number;
  preco7dia: number;
  preco15dia: number;
  categoria: Categoria;
}
