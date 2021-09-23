import styled from 'styled-components'

export const Container = styled.div`
  display: flex;
`;

export const RoundButton = styled.button`
  border: 1px solid ${props => props.theme.colors.primary};
  border-radius: 20px;
  padding: 8px 40px;
  background: transparent;
  color: ${props => props.theme.colors.text};
  font-size: 1.2rem;

  cursor: ${props => props.disabled ? 'not-allowed' : 'pointer'};

  :hover{
    opacity: ${props => props.disabled ? 0.5 : 0.8};
    transform: scale(${props => props.disabled ? 1 : 1.02});
  }
  opacity: ${props => props.disabled ? 0.5 : 1};

  transition-duration: 0.2s;
`;
