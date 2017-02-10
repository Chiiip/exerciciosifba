class ProfessorSessionsController < ApplicationController

	before_action :require_no_authentication, only: [:new, :create]

	before_action :require_authentication, only: :destroy
def new
	@professor_session = ProfessorSession.new(session)
end
def create
	@professor_session = ProfessorSession.new(session, params[:professor_session])
	if @professor_session.authenticate
		redirect_to root_path, notice: t('flash.notice.signed_in')
	else
		render :new
	end
end
	def destroy
		professor_session.destroy
		redirect_to root_path, notice: t('flash.notice.signed_out ')
	end
end
