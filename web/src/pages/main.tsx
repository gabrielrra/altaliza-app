import React from 'react'

import Head from 'next/head'
import Link from 'next/link'

import { Container } from '../styles/pages/Home'
import LinkButton from '../components/LinkButton'

const Home: React.FC = () => {
  return (
    <Container>
      <Head>
        <title>Altaliza</title>
      </Head>

      <h1>Bem Vindo</h1>
      <p>Aluguel de carros, simplificado</p>


    </Container>
  )
}

export default Home
