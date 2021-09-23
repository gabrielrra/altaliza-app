import styled from 'styled-components'

export const Container = styled.div`
  width: 100vw;
  height: 90vh;

  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;

  h1 {
    font-size: 54px;
    color: ${props => props.theme.colors.primary};
    margin-top: 40px;
  }

  p {
    font-size: 24px;
    line-height: 32px;
    margin: 24px 0px;
  }
`

export const FormContainer = styled.div`
  display: flex;
  justify-content: space-between;
  align-items: center;
  flex-direction: column;
`
