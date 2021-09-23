import React from 'react'

import Head from 'next/head'
import Link from 'next/link'


import { Container, RoundButton } from './styles'

interface Props {
  href: string;
  text: string;
}

const LinkButton: React.FC<Props> = ({href, text}) => {
  console.log(text)
  return (
    <Container>
      <Link href={href || '/'}>
        <RoundButton>
          {text}
        </RoundButton>
      </Link>

    </Container>
  )
}

export default LinkButton
