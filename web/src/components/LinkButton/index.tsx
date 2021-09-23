import React from 'react'

import Head from 'next/head'
import Link from 'next/link'


import { Container, RoundButton } from './styles'

interface Props {
  href: string;
  text: string;
  disabled?: boolean;
}

const LinkButton: React.FC<Props> = ({href, text, disabled}) => {
  return (
    <Container>
      <Link href={href || '/'} >
        <RoundButton disabled={disabled}>
          {text}
        </RoundButton>
      </Link>

    </Container>
  )
}

export default LinkButton
