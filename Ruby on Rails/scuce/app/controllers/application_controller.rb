class ApplicationController < ActionController::Base
  # Prevent CSRF attacks by raising an exception.
  # For APIs, you may want to use :null_session instead.
  protect_from_forgery with: :exception


  delegate :current_professor, :professor_signed_in?, to: :professor_session

  helper_method :current_professor, :professor_signed_in?

def professor_session
  	ProfessorSession.new(session)
end

  def require_authentication
  	unless professor_signed_in?
  		redirect_to new_professor_sessions_path,
  		alert: t('flash.alert.needs.login')
  	end
  end

  def require_no_authentication
   if professor_signed_in?
     redirect_to root_path,
     notice: t('flash.notice.already_logged_in')
     end
   end		





end
