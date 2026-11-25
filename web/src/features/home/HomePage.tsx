import {
  ArrowForward,
  CalendarMonth,
  Groups,
  Lightbulb,
  LocationOn,
  AutoAwesome,
} from '@mui/icons-material'
import { Button, Typography } from '@mui/material'
import { useNavigate } from 'react-router'
import './HomePage.css'

export default function HomePage() {
  const navigate = useNavigate()

  return (
    <main className="welcome">
      <div className="welcome__glow welcome__glow--one" aria-hidden="true" />
      <div className="welcome__glow welcome__glow--two" aria-hidden="true" />
      <div className="welcome__grid" aria-hidden="true" />

      <header className="welcome__topbar">
        <a className="welcome__brand" href="/" aria-label="Events Hub home">
          <span className="welcome__brand-icon">
            <CalendarMonth />
          </span>
          <span>
            events<span className="welcome__brand-accent">hub</span>
          </span>
        </a>
        <span className="welcome__top-note">
          <span className="welcome__live-dot" /> Make room for good things
        </span>
      </header>

      <section className="welcome__content" aria-labelledby="welcome-title">
        <div className="welcome__copy">
          <div className="welcome__eyebrow">
            <AutoAwesome fontSize="small" /> YOUR PEOPLE. YOUR PLANS.
          </div>
          <Typography
            component="h1"
            id="welcome-title"
            className="welcome__title"
          >
            Great things
            <br />
            happen <span>together.</span>
          </Typography>
          <Typography component="p" className="welcome__description">
            Find your people, make a plan, and turn a free afternoon into a
            favorite memory.
          </Typography>
          <Button
            onClick={() => navigate('/activities')}
            className="welcome__cta"
            variant="contained"
            endIcon={<ArrowForward />}
          >
            Explore activities
          </Button>
          <div className="welcome__social-proof">
            <span className="welcome__avatar-stack" aria-hidden="true">
              <span>J</span>
              <span>M</span>
              <span>A</span>
              <span>+</span>
            </span>
            <span>
              Better plans start <strong>together</strong>
            </span>
          </div>
        </div>

        <div
          className="welcome__scene"
          aria-label="Illustration of friends planning activities together"
        >
          <div
            className="welcome__orbit welcome__orbit--outer"
            aria-hidden="true"
          />
          <div
            className="welcome__orbit welcome__orbit--inner"
            aria-hidden="true"
          />
          <div
            className="welcome__spark welcome__spark--one"
            aria-hidden="true"
          >
            ✳
          </div>
          <div
            className="welcome__spark welcome__spark--two"
            aria-hidden="true"
          >
            ✦
          </div>
          <div
            className="welcome__spark welcome__spark--three"
            aria-hidden="true"
          >
            ·
          </div>

          <div className="welcome__event-card">
            <div className="welcome__event-top">
              <div className="welcome__event-date">
                <strong>24</strong>
                <span>SAT</span>
              </div>
              <span className="welcome__event-menu">•••</span>
            </div>
            <div className="welcome__event-art">
              <span>☀</span>
              <i />
              <i />
              <i />
            </div>
            <div className="welcome__event-info">
              <span className="welcome__event-tag">OUTDOORS</span>
              <h2>Golden hour picnic</h2>
              <p>
                <LocationOn fontSize="small" /> Riverside park
              </p>
              <div className="welcome__event-footer">
                <span className="welcome__mini-avatars">
                  <i>J</i>
                  <i>M</i>
                  <i>A</i>
                </span>
                <span>
                  <strong>8</strong> going
                </span>
                <span className="welcome__going">
                  <Groups fontSize="small" />
                </span>
              </div>
            </div>
          </div>

          <div className="welcome__float-card welcome__float-card--idea">
            <span className="welcome__float-icon">
              <Lightbulb />
            </span>
            <span>
              <strong>New idea!</strong>
              <small>Game night, Friday?</small>
            </span>
            <span className="welcome__float-check">✓</span>
          </div>
          <div className="welcome__float-card welcome__float-card--friends">
            <span className="welcome__friends-icon">
              <Groups />
            </span>
            <span>
              <strong>Good company</strong>
              <small>Always included</small>
            </span>
          </div>
          <div className="welcome__scene-caption">
            <span /> A little more living, together
          </div>
        </div>
      </section>

      <footer className="welcome__footer">
        <span>
          DISCOVER <i>·</i> CONNECT <i>·</i> MAKE MEMORIES
        </span>
        <span className="welcome__footer-mark">
          GOOD PLANS, GOOD PEOPLE <span>✳</span>
        </span>
      </footer>
    </main>
  )
}
