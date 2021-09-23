import React from 'react'
import Head from 'next/head'
import Link from 'next/link'
import { faChevronLeft } from '@fortawesome/free-solid-svg-icons'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'

import { Container } from './styles'
import { Veiculo } from '../../models/Veiculo'

interface InputProps  {
  item: Veiculo;
}

const ListItem: React.FC<InputProps> = ({item}) => {
  return (
    <Container>
      <img src={item.imagem} alt={item.nome} />
      <h2>{item.nome}</h2>
      <span>{item.categoria.nome}</span>
    </Container>
  )
}

export default ListItem
