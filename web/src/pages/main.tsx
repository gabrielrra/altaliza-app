import React, { useEffect, useState } from 'react'

import Head from 'next/head'
import Link from 'next/link'

import { Container } from '../styles/pages/Main'
import { api } from '../services/api'
import { Veiculo } from '../models/Veiculo'

import ListItem from '../components/ListItem'


const Home: React.FC = () => {

  const [vehicles, setVehicles] = useState<Veiculo[]>([])

  useEffect(() => {
    console.log('b')

    api.get<Veiculo[]>('veiculo').then(({data}) => {
      setVehicles(data);
    })
  }, [])
  return (
    <Container>
      <Head>
        <title>Altaliza</title>
      </Head>

      <h1>Bem Vindo</h1>
      <h3>Veículos Disponíveis</h3>
      {vehicles.map(element => {
       return <ListItem item={element} />
      })}
    </Container>
  )
}

export default Home
