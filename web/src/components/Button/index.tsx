import React from 'react'

import Head from 'next/head'
import Link from 'next/link'


import { Container, RoundButton } from './styles'

interface Props {
  text: string;
  disabled?: boolean;
  onClick: () => void;
}

const Button: React.FC<Props> = ({text, disabled, onClick}) => {
  return (
    <Container>
        <RoundButton onClick={onClick} disabled={disabled}>
          {text}
        </RoundButton>
    </Container>
  )
}

export default Button
