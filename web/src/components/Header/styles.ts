import styled from 'styled-components'

export const Container = styled.div`
  display: flex;
  flex-direction: row;

  width: 100%;
  height: 2rem;
  padding: 20px;
  color: ${props => props.theme.colors.primary};

  a {
    color: unset;
    cursor: pointer;
  }
`;
